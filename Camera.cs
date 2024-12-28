using MvCameraControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingCaptureDotNet
{
    class Camera
    {
        PictureBox pictureBox;
        IGigEDevice device;
        public Camera(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            Console.WriteLine("Scanning Camera...");

            SDKSystem.Initialize();
            List<IDeviceInfo> deviceInfoList = null;
            var ret = DeviceEnumerator.EnumDevices(DeviceTLayerType.MvGigEDevice, out deviceInfoList);
            if (ret != MvError.MV_OK || deviceInfoList.Count != 1)
                throw new Exception($"Camera Init Error: Can not get the camera.");
            var device = DeviceFactory.CreateDevice(deviceInfoList[0]) as IGigEDevice
                ?? throw new Exception("Cast to GigE Error.");
            device.Open();
            var packetSize = -1;
            device.GetOptimalPacketSize(out packetSize);
            device.Parameters.SetIntValue("GevSCPSPacketSize", packetSize);
            device.StreamGrabber.SetImageNodeNum(5);
            this.device = device;
        }

        public void startGrabing()
        {
            EventHandler<FrameGrabbedEventArgs> handler = (sender, e) =>
            {
                pictureBox.Invoke(new Action(() =>
                {
                    if (pictureBox.Image != null)
                    {
                        pictureBox.Image.Dispose();
                    }
                    pictureBox.Image = e.FrameOut.Image.ToBitmap();
                }));
            };
            device.StreamGrabber.FrameGrabedEvent += handler;
            device.StreamGrabber.StartGrabbing();
        }
    }
}
