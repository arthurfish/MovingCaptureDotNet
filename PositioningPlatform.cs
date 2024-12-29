using cszmcaux;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingCaptureDotNet
{
    class PositioningPlatform : INotifyPropertyChanged
    {
        private int xAxis = 0;
        private int yAxis = 1;
        private (float x, float y) positionLimitMillimeter = (70, 70);
        private (float, float) clipPosition((float x, float y) position)
        {
            var x = position.x;
            var y = position.y;
            if (x < -positionLimitMillimeter.x)
                x = -positionLimitMillimeter.x;
            if (x > positionLimitMillimeter.x)
                x = positionLimitMillimeter.x;
            if (y < -positionLimitMillimeter.y)
                y = -positionLimitMillimeter.y;
            if (y > positionLimitMillimeter.y)
                y = positionLimitMillimeter.y;
            return (x, y);
        }
        private float _stepSize = 5;
        public float stepSize
        {
            get { return _stepSize; }
            set
            {
                _stepSize = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(stepSize)));
            }
        }


        (float x, float y) _position;
        public (float x, float y) position
        {
            get
            {
                zmcaux.ZAux_Direct_GetDpos(deviceHandle, xAxis, ref _position.x);
                zmcaux.ZAux_Direct_GetDpos(deviceHandle, yAxis, ref _position.y);
                Console.WriteLine($"pos read. ({_position.x}, {_position.y})");
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(position)));
                return _position;
            }
            set
            {
                _position = clipPosition(value);
                zmcaux.ZAux_Direct_Single_MoveAbs(deviceHandle, xAxis, _position.x);
                zmcaux.ZAux_Direct_Single_MoveAbs(deviceHandle, yAxis, _position.y);
                Console.WriteLine($"pos set. ({_position.x}, {_position.y})");
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(position)));
            }
        }
        private float _velocity;
        public float velocity
        {
            get
            {
                zmcaux.ZAux_Direct_GetSpeed(deviceHandle, xAxis, ref _velocity);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(velocity)));
                return _velocity;
            }
            set
            {
                zmcaux.ZAux_Direct_SetSpeed(deviceHandle, xAxis, _velocity);
                _velocity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(velocity)));
            }
        }

        public void incrementMove(float deltaX, float deltaY)
        {
            Console.WriteLine($"incrementMove({deltaX}, {deltaY})");
            zmcaux.ZAux_Direct_Single_Move(deviceHandle, xAxis, deltaX);
            zmcaux.ZAux_Direct_Single_Move(deviceHandle, yAxis, deltaY);

            var _ = position;
        }

        private float _startX0, _startY0, _endX1, _endY1;
        public float startX0
        {
            get => _startX0;
            set
            {
                _startX0 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(startX0)));
            }
        }
        public float startY0
        {
            get => _startY0;
            set
            {
                _startY0 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(startY0)));
            }
        }
        public float endX1
        {
            get => _endX1;
            set
            {
                _endX1 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(endX1)));
            }
        }
        public float endY1
        {
            get => _endY1;
            set
            {
                _endY1 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(endY1)));
            }
        }

        private static IntPtr deviceHandle;

        public event PropertyChangedEventHandler PropertyChanged;

        public PositioningPlatform(string ipAddress = "192.168.0.11")
        {
            var ret = zmcaux.ZAux_OpenEth(ipAddress, out deviceHandle);
            if (ret != 0) throw new Exception("Can not connect to PLATFORM.");
            zmcaux.ZAux_Direct_SetAtype(deviceHandle, 0, 65);
            zmcaux.ZAux_Direct_SetUnits(deviceHandle, 0, 20000);
            zmcaux.ZAux_Direct_SetAccel(deviceHandle, 0, 1000);
            zmcaux.ZAux_Direct_SetDecel(deviceHandle, 0, 1000);
            zmcaux.ZAux_Direct_SetSpeed(deviceHandle, 0, 50);

        }
    }
}
