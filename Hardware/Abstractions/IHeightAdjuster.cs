using System;
using System.ComponentModel;

namespace MovingCaptureDotNet.Hardware.Abstractions
{
    public interface IHeightAdjuster : INotifyPropertyChanged
    {
        /// <summary>
        /// Gets or sets the target position in millimeters (or generic units).
        /// </summary>
        double ExpectedPosition { get; set; }

        /// <summary>
        /// Step size for manual adjustments.
        /// </summary>
        double StepSize { get; set; }

        /// <summary>
        /// Move increment.
        /// </summary>
        void MoveRelative(double delta);
        void ApplyMotion();

        /// <summary>
        /// Connect to the device.
        /// </summary>
        bool Connect();

        /// <summary>
        /// Disconnect from the device.
        /// </summary>
        void Disconnect();
    }
}
