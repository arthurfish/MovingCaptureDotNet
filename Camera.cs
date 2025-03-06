using MvCameraControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingCaptureDotNet
{
    class Camera: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        PictureBox pictureBox;
        IGigEDevice device;
        private float _exposureTime = 250000;
        public float exposureTime
        {
            get {
                IFloatValue outValue;
                infoCameraError(this.device.Parameters.GetFloatValue("ExposureTime", out outValue));
                _exposureTime = outValue.CurValue;
                RaisePropertyChanged();
                return _exposureTime;
            }
            set
            {
                if (_exposureTime != value)
                {
                    _exposureTime = value;
                    infoCameraError(this.device.Parameters.SetFloatValue("ExposureTime", value));
                    RaisePropertyChanged();
                }
            }
        }
        private int _captureNumber = 1;
        public int captureNumber
        {
            get => _captureNumber;
            set
            {
                if (_captureNumber != value)
                {
                    _captureNumber = value;
                    RaisePropertyChanged();
                }
            }
        }
        private int _captureProgressPercentage = 0;
        public int captureProgressPercentage
        {
            get => _captureProgressPercentage;
            set
            {
                _captureProgressPercentage = value;
                RaisePropertyChanged();
            }
        }
        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
    => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        private void infoCameraError(Int32 ret) => CameraErrorInfo.infoCameraError(ret);


        public Camera(PictureBox pictureBox)
        {
            try
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
                infoCameraError(device.Open());

                var packetSize = -1;
                infoCameraError(device.GetOptimalPacketSize(out packetSize));
                infoCameraError(device.Parameters.SetIntValue("GevSCPSPacketSize", packetSize));
                device.StreamGrabber.SetImageNodeNum(5);
                this.device = device;
                Console.WriteLine("Camera Got.");
            }
            catch (Exception ex)
            {
//              disposeCamera();
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public void startGrabing()
        {
            if (this.device ==null)
            {
                return;
            }
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
//            device.StreamGrabber.FrameGrabedEvent += handler;
            infoCameraError(device.StreamGrabber.StartGrabbing());
            Console.WriteLine("Camera: Start Grabbing.");
        }

        public Bitmap getImage()
        {
            IFrameOut frame;
            infoCameraError(this.device.StreamGrabber.GetImageBuffer(1000, out frame));
            if (frame == null)
            {
                return null;
            }
            var bitmap = frame.Image.ToBitmap();
            infoCameraError(this.device.StreamGrabber.FreeImageBuffer(frame));
            return bitmap;
        }

        public void disposeCamera()
        {
            try
            {
//                infoCameraError(device.StreamGrabber.StopGrabbing());
//                Console.WriteLine("Grabbing Stoped.");
                infoCameraError(device.Close());
                Console.WriteLine("Device Closed.");
                device.Dispose();
                Console.WriteLine("device Disposed.");
                infoCameraError(SDKSystem.Finalize());
                Console.WriteLine("SDK finalized.");

            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
