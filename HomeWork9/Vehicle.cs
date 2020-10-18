using System;
using System.Collections.Generic;
using System.Text;

namespace dz9
{
    class Vehicle
    {
        public int Coordinate { get; set; }
        public double Price { get; set; }
        public int Speed { get; set; }
        public int Year { get; set; }

        public Vehicle(int coordinate, double price, int speed, int year)
        {
            Coordinate = coordinate;
            Price = price;
            Speed = speed;
            Year = year;
        }
    }
}
