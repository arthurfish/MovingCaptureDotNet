using System;

namespace MovingCaptureDotNet.Domain.Models
{
    public interface IMotion
    {
        string Id { get; }
        double DeltaX { get; }
        double DeltaY { get; }
        double DeltaZ { get; }
        int Steps { get; }
        string Description { get; }
    }

    public class CartesianCoordinateDirectionalMotion : IMotion
    {
        private double _deltaX, _deltaY, _deltaZ;
        private int _steps;
        
        public CartesianCoordinateDirectionalMotion(double deltaX, double deltaY, double deltaZ, int steps)
        {
            _deltaX = deltaX;
            _deltaY = deltaY;
            _deltaZ = deltaZ;
            _steps = steps;
        }

        public double DeltaX => _deltaX;
        public double DeltaY => _deltaY;
        public double DeltaZ => _deltaZ;
        public int Steps => _steps;
        public string Description => $"[C] {_steps}x (Δx: {_deltaX:F2}[mm], Δy: {_deltaY:F2}[mm])";
        
        private string _id = System.Guid.NewGuid().ToString("N");
        public string Id => _id;
    }

    public class PolarCoordinateDirectionalMotion : IMotion
    {
        private double _deltaR, _theta, _deltaZ;
        private int _steps;

        public PolarCoordinateDirectionalMotion(double theta, double deltaR, double deltaZ, int steps)
        {
            _deltaR = deltaR;
            _theta = theta;
            _steps = steps;
            _deltaZ = deltaZ;
        }

        private double DegreesToRadians(double degrees) => degrees * Math.PI / 180.0;

        public double DeltaZ => _deltaZ;
        public double DeltaX => _deltaR * Math.Cos(DegreesToRadians(_theta));
        public double DeltaY => _deltaR * Math.Sin(DegreesToRadians(_theta));
        public int Steps => _steps;
        public string Description => $"[P] {_steps}x (θ: {_theta:F2}[deg], Δr: {_deltaR:F2}[mm])";

        private string _id = System.Guid.NewGuid().ToString("N");
        public string Id => _id;
    }
}
