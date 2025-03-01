using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MovingCaptureDotNet
{
    interface IMotion
    {
        string Id { get; }
        double DeltaX { get; }
        double DeltaY { get; }
        int Steps { get;  }
        String Description { get; }
    }
    class CartesianCoordinateDirectionalMotion : IMotion
    {
        private double _deltaX, _deltaY;
        private int _steps;
        public CartesianCoordinateDirectionalMotion(double deltaX, double deltaY, int steps)
        {
            _deltaX = deltaX;
            _deltaY = deltaY;
            _steps = steps;
        }
        public double DeltaX => _deltaX;
        public double DeltaY => _deltaY;
        public String Description => $"[C] {_steps}x (Δx: {_deltaX:F2}[mm], Δy: {_deltaY:F2}[mm])";
        private string _id = System.Guid.NewGuid().ToString("N");
        public string Id => _id;
        public int Steps => _steps;
    }
    class PolarCoordinateDirectionalMotion : IMotion
    {
        private double _deltaR, _theta;
        private int _steps;
        public PolarCoordinateDirectionalMotion(double theta, double deltaR, int steps)
        {
            _deltaR = deltaR;
            _theta = theta;
            _steps = steps;
        }
        public double DeltaX => _deltaR * Math.Cos(_theta);
        public double DeltaY => _deltaR * Math.Sin(_theta);
        public String Description => $"[P] {_steps}x (θ: {_theta:F2}[deg], Δr: {_deltaR:F2}[mm])";
        private string _id = System.Guid.NewGuid().ToString("N");
        public string Id => _id;
        public int Steps => _steps;
    }

    class MotionUtils
    {
        public static void applyMotions(IEnumerable<IMotion> motions, Action<IMotion> move, Func<bool> isAvaliable, Action<double> setProgress, Action takePhoto)
        {
            var total = 0;
            foreach (IMotion mot in motions)
            {
                total += mot.Steps;
            }
            var counter = 0;
            foreach(IMotion mot in motions)
            {
                for (int i = 0; i < mot.Steps; i++)
                {
                    move(mot);
                    setProgress((counter+1.0)/total);
                    while (!isAvaliable()) ;
                    System.Threading.Thread.Sleep(500);
                    takePhoto();
                    System.Threading.Thread.Sleep(500);
                    counter++;
                }
            }
        }
    }
}