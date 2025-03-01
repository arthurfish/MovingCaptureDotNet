using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerialPortLibrary;
using System.IO.Ports;
using System.Windows.Forms;
using System.ComponentModel;



namespace MovingCaptureDotNet
{
    class HeightAdjustDevice: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private SPLibClass _device;
        private int AxisId = 0;
        public readonly double StepAngle = 1.8;
        public readonly float LeadScrewPitch = 5;
        private readonly int PositiveDirection = 1;
        private double _stepSize = 1;
        public double StepSize
        {
            get => _stepSize;
            set
            {
                _stepSize = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StepSize)));
            }
        }

        private int _microsteppingFactor = 20;
        public int MicrosteppingFactor
        {
            get => _microsteppingFactor;
        }
        public int StepsPerRevolution => (int)(360 / StepAngle);
        public float PulsePerMillimeter => LeadScrewPitch / (StepsPerRevolution * MicrosteppingFactor);
        private bool IsSuccess(int result)
        {
            return result == 1;
        }
        
        private double _position = 0;
        public double Position
        {
            get {
                float[] temp = new float[1];
                _device.MoCtrCard_GetAxisPos((byte)AxisId, temp);
                _position = temp[0];
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Position)));
                Console.WriteLine($"Height(get): {_position}");
                return _position;
            }
            set
            {
                if (value != _position)
                {
                    _position = value;
                    _device.MoCtrCard_MCrlAxisAbsMove((byte)AxisId, (float)_position, 10, 10);
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Position)));
                    Console.WriteLine($"Height(set): {_position}");
                }
            }
        }

        public HeightAdjustDevice()
        {
            _device = new SPLibClass();
            var openSerialPortSuccess = false;
            foreach(String port in SerialPort.GetPortNames())
            {
                if (IsSuccess(_device.MoCtrCard_Initial(port)))
                {
                    openSerialPortSuccess = true;
                    break;
                }
            }
            if(!openSerialPortSuccess)
            {
                throw new Exception("Can NOT open the height adjust motor.");
            }
            
        }

        ~HeightAdjustDevice()
        {
            _device.MoCtrCard_Unload();
        }
    }
}
