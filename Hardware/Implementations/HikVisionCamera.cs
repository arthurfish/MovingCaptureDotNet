using MovingCaptureDotNet.Hardware.Abstractions;
using MvCameraControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

using MovingCaptureDotNet.Hardware.Implementations;
using MovingCaptureDotNet.Hardware.Utils;
using System.Diagnostics;
namespace MovingCaptureDotNet.Hardware.Implementations{
    public class HikVisionCamera : ICamera
    {
        private IGigEDevice _device;
        private float _exposureTime = 250000;
        private int _captureNumber = 1;

        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler<Bitmap> FrameReceived;

        public float ExposureTime
        {
            get
            {
                if (_device != null)
                {
                    IFloatValue outValue;
                    if (_device.Parameters.GetFloatValue("ExposureTime", out outValue) == MvError.MV_OK)
                    {
                        _exposureTime = outValue.CurValue;
                    }
                }
                return _exposureTime;
            }
            set
            {
                if (_exposureTime != value)
                {
                    _exposureTime = value;
                    if (_device != null)
                    {
                         _device.Parameters.SetFloatValue("ExposureTime", value);
                    }
                    OnPropertyChanged();
                }
            }
        }

        public int CaptureNumber
        {
            get => _captureNumber;
            set
            {
                if (_captureNumber != value)
                {
                    _captureNumber = value;
                    OnPropertyChanged();
                }
            }
        }

        public void Initialize()
        {
            SDKSystem.Initialize();
            List<IDeviceInfo> deviceInfoList = null;
            int ret = DeviceEnumerator.EnumDevices(DeviceTLayerType.MvGigEDevice, out deviceInfoList);
            
            if (ret != MvError.MV_OK || deviceInfoList.Count == 0)
                throw new Exception("No Camera Found.");

            _device = DeviceFactory.CreateDevice(deviceInfoList[0]) as IGigEDevice;
            if (_device == null) throw new Exception("Failed to create GigE device.");

            ret = _device.Open();

            if (ret != MvError.MV_OK) throw new Exception($"Failed to open camera. Error: {CameraErrorInfo.getErrorInfo((uint)ret)}");

            int packetSize = -1;
            if (_device.GetOptimalPacketSize(out packetSize) == MvError.MV_OK) 
            {
                _device.Parameters.SetIntValue("GevSCPSPacketSize", packetSize);
            }
            
            _device.StreamGrabber.SetImageNodeNum(5);
            _device.StreamGrabber.StartGrabbing();
        }

        public void StartGrabbing()
        {
            if (_device == null) return;
            
            // Register callback or just start? 
            // Original used explicit GetImageBuffer loop or callback.
            // I will implement a simpler callback mechanism for "FrameReceived".
            
            _device.StreamGrabber.FrameGrabedEvent += OnImageGrabbed;
            _device.StreamGrabber.StartGrabbing();
        }

        private void OnImageGrabbed(object sender, FrameGrabbedEventArgs e)
        {
             // This is a placeholder for callback logic if we used the event-based approach from SDK.
             // However, original code 'startGrabing' had a commented out event handler and used polling in Form1 timer.
             // We'll stick to GetImage for now to be safe, or allow the user to use GetImage.
        }

        public void StopGrabbing()
        {
             if (_device != null)
             {
                 _device.StreamGrabber.FrameGrabedEvent -= OnImageGrabbed;
                 _device.StreamGrabber.StopGrabbing();
             }
        }

        public Bitmap GetImage()
        {
            if (_device == null) return null;
            IFrameOut frame;
            int ret = _device.StreamGrabber.GetImageBuffer(1000, out frame);
            if (ret == MvError.MV_OK && frame != null)
            {
                var bitmap = frame.Image.ToBitmap();
                _device.StreamGrabber.FreeImageBuffer(frame);
//                Trace.WriteLine($"[Camera.GetImage()] Got Image bitmap. Height:{bitmap.Height} Width:{bitmap.Width}");
                return bitmap;
            }
            else
            {
                Trace.WriteLine($"[Camera.GetImage()] {CameraErrorInfo.getErrorInfo((uint)ret)}");
            }
            return null;
        }

        public void Dispose()
        {
            try
            {
                StopGrabbing();
                if (_device != null)
                {
                    _device.Close();
                    _device.Dispose();
                }
                SDKSystem.Finalize();
            }
            catch
            {
                // Suppress disposal errors
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
