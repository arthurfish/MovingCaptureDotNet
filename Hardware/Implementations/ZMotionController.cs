using MovingCaptureDotNet.Hardware.Drivers;
using MovingCaptureDotNet.Hardware.Abstractions;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MovingCaptureDotNet.Hardware.Implementations
{
    public class ZMotionController : IMotionController
    {
        private IntPtr _deviceHandle;
        private const int XAxisId = 1;
        private const int YAxisId = 0;
        private (float x, float y) _positionLimit = (70, 70);
        
        // Backing fields for properties
        private float _velocity = 50;
        
        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsMoving
        {
            get
            {
                int xIdle = 0, yIdle = 0;
                // Only check if handle is valid to avoid crash
                if (_deviceHandle != IntPtr.Zero)
                {
                    zmcaux.ZAux_Direct_GetIfIdle(_deviceHandle, XAxisId, ref xIdle);
                    zmcaux.ZAux_Direct_GetIfIdle(_deviceHandle, YAxisId, ref yIdle);
                }
                return xIdle == 0 || yIdle == 0;
            }
        }

        public (float X, float Y) Position
        {
            get
            {
                float x = 0, y = 0;
                if (_deviceHandle != IntPtr.Zero)
                {
                    zmcaux.ZAux_Direct_GetDpos(_deviceHandle, YAxisId, ref y);
                    zmcaux.ZAux_Direct_GetDpos(_deviceHandle, XAxisId, ref x);
                }
                // Original logic inverted signs
                return (-x, -y);
            }
        }

        public float Velocity
        {
            get
            {
                // We could read from device, but simplest is to return cached or read fresh
                if (_deviceHandle != IntPtr.Zero)
                {
                    float currentSpeed = 0;
                    zmcaux.ZAux_Direct_GetSpeed(_deviceHandle, XAxisId, ref currentSpeed);
                    _velocity = currentSpeed;
                }
                return _velocity;
            }
            set
            {
                _velocity = value;
                if (_deviceHandle != IntPtr.Zero)
                {
                    zmcaux.ZAux_Direct_SetSpeed(_deviceHandle, XAxisId, _velocity);
                    // Assuming symmetric speed for now? Original code only set X axis speed in setter property.
                    zmcaux.ZAux_Direct_SetSpeed(_deviceHandle, YAxisId, _velocity); 
                }
                OnPropertyChanged();
            }
        }

        public void Connect(string ipAddress = "192.168.0.11")
        {
            int ret = zmcaux.ZAux_OpenEth(ipAddress, out _deviceHandle);
            if (ret != 0)
            {
                throw new Exception($"Failed to connect to ZMotion Controller at {ipAddress}. Error code: {ret}");
            }
            Initialize();
        }

        public void Initialize()
        {
            if (_deviceHandle == IntPtr.Zero) return;

            // Common initialization from original code
             // Assuming axis 0 is Y and axis 1 is X based on usage
            // The original constructor only set params for axis 0? That seems like a bug or simplification in original code.
            // I will apply to safe defaults or both axes if logical.
            
            // NOTE: Original code only initialized Axis 0 parameters!
            // zmcaux.ZAux_Direct_SetAtype(deviceHandle, 0, 65); ...
            // But used xAxis=1 and yAxis=0.
            
            ConfigureAxis(YAxisId);
            ConfigureAxis(XAxisId);

            zmcaux.ZAux_Direct_SetAxisEnable(_deviceHandle, XAxisId, 1);
            zmcaux.ZAux_Direct_SetAxisEnable(_deviceHandle, YAxisId, 1);
        }

        private void ConfigureAxis(int axisId)
        {
            zmcaux.ZAux_Direct_SetAtype(_deviceHandle, axisId, 65); 
            zmcaux.ZAux_Direct_SetUnits(_deviceHandle, axisId, 20000);
            zmcaux.ZAux_Direct_SetAccel(_deviceHandle, axisId, 1000);
            zmcaux.ZAux_Direct_SetDecel(_deviceHandle, axisId, 1000);
            zmcaux.ZAux_Direct_SetSpeed(_deviceHandle, axisId, _velocity);
        }

        private (float x, float y) ClipPosition(float x, float y)
        {
            if (x < -_positionLimit.x) x = -_positionLimit.x;
            if (x > _positionLimit.x) x = _positionLimit.x;
            if (y < -_positionLimit.y) y = -_positionLimit.y;
            if (y > _positionLimit.y) y = _positionLimit.y;
            return (x, y);
        }

        public void MoveAbsolute(float x, float y)
        {
            if (_deviceHandle == IntPtr.Zero) return;

            var clipped = ClipPosition(x, y);
            // Original logic: -clipped.Y for X axis move? wait.
            // Original:
            // zmcaux.ZAux_Direct_Single_MoveAbs(deviceHandle, xAxis, -_position.y);
            // zmcaux.ZAux_Direct_Single_MoveAbs(deviceHandle, yAxis, -_position.x);
            // This looks like a mixup in the original code naming or logic.
            // xAxis is 1. Position.y is passed to it?
            
            // Let's preserve original logic behavior:
            // xAxis (1) gets -y
            // yAxis (0) gets -x
            // This implies the physical axes are swapped/rotated 90 degrees or names are confusing.
            // I will use X -> -Y param, Y -> -X param to match original "Position" setter logic.
            
            zmcaux.ZAux_Direct_Single_MoveAbs(_deviceHandle, XAxisId, -clipped.y);
            zmcaux.ZAux_Direct_Single_MoveAbs(_deviceHandle, YAxisId, -clipped.x);
            
            OnPropertyChanged(nameof(Position));
        }

        public void MoveRelative(float deltaX, float deltaY)
        {
             if (_deviceHandle == IntPtr.Zero) return;
             
             // Original: 
             // zmcaux.ZAux_Direct_Single_Move(deviceHandle, xAxis, -deltaY);
             // zmcaux.ZAux_Direct_Single_Move(deviceHandle, yAxis, -deltaX);
             
             zmcaux.ZAux_Direct_Single_Move(_deviceHandle, XAxisId, -deltaY);
             zmcaux.ZAux_Direct_Single_Move(_deviceHandle, YAxisId, -deltaX);
             
             OnPropertyChanged(nameof(Position));
        }

        public void Stop()
        {
             if (_deviceHandle == IntPtr.Zero) return;
             zmcaux.ZAux_Direct_Single_Cancel(_deviceHandle, XAxisId, 2); 
             zmcaux.ZAux_Direct_Single_Cancel(_deviceHandle, YAxisId, 2);
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
