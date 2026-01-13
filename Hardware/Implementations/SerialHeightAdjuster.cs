using MovingCaptureDotNet.Hardware.Abstractions;
using SerialPortLibrary;
using System;
using System.ComponentModel;
using System.IO.Ports;
using System.Runtime.CompilerServices;

namespace MovingCaptureDotNet.Hardware.Implementations
{
    public class SerialHeightAdjuster : IHeightAdjuster
    {
        private SPLibClass _device;
        private const int AxisId = 0;
        private double _position = 0;
        private double _stepSize = 1.0;
        private bool _isConnected = false;

        public event PropertyChangedEventHandler PropertyChanged;

        private double _expectedPosition = 0;
        public double ExpectedPosition
        {
            get => _expectedPosition;
            set
            {
                if(_expectedPosition != value)
                {
                    _expectedPosition = value;
                    OnPropertyChanged();
                }
            }
        }

        public double GetActualPosition()
        {
            if (_isConnected && _device != null)
            {
                try
                {
                    float[] temp = new float[1];
                    _device.MoCtrCard_GetAxisPos((byte)AxisId, temp);
                    _position = temp[0];
                }
                catch
                {
                    // Log error?
                }
            }
            return _position;
        }

        public void ApplyMotion()
        {
            if (_isConnected && _device != null)
            {
                _device.MoCtrCard_MCrlAxisAbsMove((byte)AxisId, (float)_expectedPosition, 5, 1);
            }
        }

        public double StepSize
        {
            get => _stepSize;
            set
            {
                if (_stepSize != value)
                {
                    _stepSize = value;
                    OnPropertyChanged();
                }
            }
        }

        public SerialHeightAdjuster()
        {
            _device = new SPLibClass();
        }

        public bool Connect()
        {
            if (_isConnected) return true;

            foreach (String port in SerialPort.GetPortNames())
            {
                if (_device.MoCtrCard_Initial(port) == 1) // 1 == success in original code
                {
                    _isConnected = true;
                    return true;
                }
            }
            return false;
        }

        public void Disconnect()
        {
            if (_isConnected && _device != null)
            {
                _device.MoCtrCard_Unload();
                _isConnected = false;
            }
        }

        public void MoveRelative(double delta)
        {
            ExpectedPosition += delta;
            ApplyMotion();
        }


        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        ~SerialHeightAdjuster()
        {
            Disconnect();
        }
    }
}
