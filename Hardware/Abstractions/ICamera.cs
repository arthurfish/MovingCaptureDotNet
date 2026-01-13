using System;
using System.Drawing;
using System.ComponentModel;

namespace MovingCaptureDotNet.Hardware.Abstractions
{
    public interface ICamera : INotifyPropertyChanged, IDisposable
    {
        /// <summary>
        /// Exposure time in microseconds.
        /// </summary>
        float ExposureTime { get; set; }

        /// <summary>
        /// Number of images to capture in a sequence (if applicable to logic).
        /// </summary>
        int CaptureNumber { get; set; }

        /// <summary>
        /// Initialize and connect to the camera.
        /// </summary>
        void Initialize();

        /// <summary>
        /// Start continuous grabbing.
        /// </summary>
        void StartGrabbing();

        /// <summary>
        /// Stop continuous grabbing.
        /// </summary>
        void StopGrabbing();

        /// <summary>
        /// Capture a single image immediately.
        /// </summary>
        /// <returns>Bitmap of the captured frame, or null on failure.</returns>
        Bitmap GetImage();

        /// <summary>
        /// Event fired when a new frame is ready (for continuous display).
        /// </summary>
        event EventHandler<Bitmap> FrameReceived;
    }
}
