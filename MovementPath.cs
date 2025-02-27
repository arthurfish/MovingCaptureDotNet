using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingCaptureDotNet
{
    interface IMotion
    {
        string Id { get; }
        double DeltaX { get; }
        double DeltaY { get; }
        String Description { get; }
    }
    class CartesianCoordinateDirectionalMotion : IMotion
    {
        private double _deltaX, _deltaY;
        public CartesianCoordinateDirectionalMotion(double deltaX, double deltaY)
        {
            _deltaX = deltaX;
            _deltaY = deltaY;
        }
        public double DeltaX => _deltaX;
        public double DeltaY => _deltaY;
        public String Description => $"(Δx: {_deltaX:F2}[mm], Δy: {_deltaY:F2}[mm])";
        private string _id = System.Guid.NewGuid().ToString("N");
        public string Id => _id;
    }
    class PolarCoordinateDirectionalMotion : IMotion
    {
        private double _deltaR, _theta;
        public PolarCoordinateDirectionalMotion(double theta, double deltaR)
        {
            _deltaR = deltaR;
            _theta = theta;
        }
        public double DeltaX => _deltaR * Math.Cos(_theta);
        public double DeltaY => _deltaR * Math.Sin(_theta);
        public String Description => $"(θ: {_theta:F2}[deg], Δr: {_deltaR:F2}[mm])";
        private string _id = System.Guid.NewGuid().ToString("N");
        public string Id => _id;
    }
}