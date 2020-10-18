using System;
using System.Collections.Generic;
using System.Text;

namespace dz7
{
    public class Parallelepiped : IFigure //Figure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Parallelepiped(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }
        public string Volume()
        {
            return $"Объем паралеллепипеда: {A*B*C}";
        }
    }
}
