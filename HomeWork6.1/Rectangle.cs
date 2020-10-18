using System;
using System.Collections.Generic;
using System.Text;

namespace dz6
{
    class Rectangle
    {
        double _side1;
        double _side2;

        public Rectangle(double side1, double side2)
        {
            _side1 = side1;
            _side2 = side2;
        }

        double _area;
        public double Area
        {
            get
            {
                return _area;
            }
        }

        double _perimeter;
        public double Perimeter
        {
            get
            {
                return _perimeter;
            }
        }

        public double AreaCalculator()
        {
            _area = _side1 * _side2;
            return _area;
        }

        public double PerimeterCalculator()
        {
            _perimeter = (_side1 + _side2) * 2;
            return _perimeter;
        }

    }
}
