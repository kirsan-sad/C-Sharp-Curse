using System;
using System.Collections.Generic;
using System.Text;

namespace dz7
{
    public class Tetrahedron : IFigure //Figure
    {
        public double Lenght { get; set; }

        public Tetrahedron (double lenght)
        {
            Lenght = lenght;
        }

        public string Volume()
        {
            return $"Объем тетройда: {Math.Pow(Lenght, 3) * Math.Sqrt(2) / 12}";
        }
    }
}
