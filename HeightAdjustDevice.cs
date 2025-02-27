using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerialPortLibrary;
using System.IO.Ports;
using System.Windows.Forms;



namespace MovingCaptureDotNet
{
    class HeightAdjustDevice
    {
        private SPLibClass _device;
        private int AxisId = 0;
        public readonly double StepAngle = 1.8;
        public readonly float LeadScrewPitch = 5;
        private readonly int PositiveDirection = 1;

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
        public void MoveTo(float distanceInMilimeter)
        {
            //Suppose it works.
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
