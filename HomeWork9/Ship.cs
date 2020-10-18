using System;
using System.Collections.Generic;
using System.Text;

namespace dz9
{
    class Ship : Vehicle
    {
        public int Passengers { get; set; }
        public string Port { get; set; }

        public Ship(int coordinate, int passengers, string port, double price, int speed, int year)
       : base(coordinate, price, speed, year)
        {
            Passengers = passengers;
            Port = port;
        }

        public override string ToString()
        {
            return $"Корабль\nПассажиров: {Passengers} человек\nПорт: {Port} \nЦена билета: {Price} доларов\nСкорость: {Speed} узлов\nГод выпуска:{Year} год\n\n";
        }
    }

}
