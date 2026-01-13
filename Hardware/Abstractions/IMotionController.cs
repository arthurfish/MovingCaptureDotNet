using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace MovingCaptureDotNet.Hardware.Abstractions
{
    public interface IMotionController : INotifyPropertyChanged
    {
        /// <summary>
        /// Gets current X, Y position in millimeters.
        /// </summary>
        (float X, float Y) Position { get; }

        /// <summary>
        /// Gets or sets target movement velocity.
        /// </summary>
        float Velocity { get; set; }

        /// <summary>
        /// Gets checking status if the platform is currently moving.
        /// </summary>
        bool IsMoving { get; }

        /// <summary>
        /// Move to absolute position.
        /// </summary>
        void MoveAbsolute(float x, float y);

        /// <summary>
        /// Move relative to current position.
        /// </summary>
        void MoveRelative(float deltaX, float deltaY);

        /// <summary>
        /// Stop movement immediately.
        /// </summary>
        void Stop();

        /// <summary>
        /// Connect to the device.
        /// </summary>
        void Connect(string connectionString);
        
        /// <summary>
        /// Initialize the device settings.
        /// </summary>
        void Initialize();
    }
}
