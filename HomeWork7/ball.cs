using System;
using System.Collections.Generic;
using System.Text;

namespace dz7
{
    class Ball : IFigure //Figure
    {
        public const double pi = 3.14;
        public double Radius { get; set; }

        public Ball(double radius)
        {
            Radius = radius;
        }
        public string Volume()
        {
            return $"Объем шара: {4 / 3 * pi * Math.Pow(Radius, 3)}";
        }
    }
}
