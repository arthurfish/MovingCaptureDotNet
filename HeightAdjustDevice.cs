using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerialPortLibrary;
using System.IO.Ports;
using System.Windows.Forms;
using System.ComponentModel;
using System.Diagnostics;



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
        
        public double _position = 0;
        public double Position
        {
            get {
                try
                {
                    float[] temp = new float[1];
                    _device.MoCtrCard_GetAxisPos((byte)AxisId, temp);
                    _position = temp[0];
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Position)));
                    Console.WriteLine($"Height(get): {_position}");
                }
                catch
                {

                }
                return _position;
            }
            set
            {
                if (value != _position)
                {
                    _position = value;
                    _device.MoCtrCard_MCrlAxisAbsMove((byte)AxisId, (float)_position, 5, 1);
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Position)));
                    Console.WriteLine($"Height(set): {_position}");
                }
            }
        }

        public void IncrementMove(float deltaZ)
        {
            Position = Position + deltaZ;
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
                //                throw new Exception("Can NOT open the height adjust motor.");
                Trace.WriteLine("Can not open Height Device");

            }
            
        }

        ~HeightAdjustDevice()
        {
            _device.MoCtrCard_Unload();
        }
    }
}
