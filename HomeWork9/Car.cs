using System;
using System.Collections.Generic;
using System.Text;

namespace dz9
{
    class Car : Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public Car(int coordinate, string brand, string model, double price, int speed, int year)
               : base(coordinate, price, speed, year)
        {
            Brand = brand;
            Model = model;
        }

        public override string ToString()
        {
            return $"Машина\nМарка: {Brand}\nМодель: {Model} \nЦена билета: {Price} доларов\nСкорость: {Speed} км/ч\nГод выпуска:{Year} год\n\n";
        }
    }
}
