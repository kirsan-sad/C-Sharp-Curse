using System;
using System.Collections.Generic;
using System.Text;

namespace dz7
{
    public class Pyramid : IFigure //Figure
    {
        public int Height { get; set; }
        public int Area { get; set; }

        public Pyramid (int height, int area)
        {
            Height = height;
            Area = area;
        }

        public string Volume()
        {
            return $"Объем пирамиды: {(Height * Area)/3}";
        }
    }
}
