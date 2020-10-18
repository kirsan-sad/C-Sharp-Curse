using System;
using System.Collections.Generic;
using System.Text;

namespace dz9
{
    class Plane : Vehicle
    {
        public int Passengers { get; set; }
        public int Height { get; set; }

        public Plane(int coordinate, double price, int speed, int year)
            : base(coordinate, price, speed, year)
        {
            // конструктор с малым количестовом параметров, но с добавлением их через инициализатор
        }

        public override string ToString()
        {
            return $"Самолет\nКоличество пассажиров: {Passengers} человек\nВысота полета: {Height} метров\nЦена билета: {Price} доларов\nСкорость: {Speed} км/ч\nГод выпуска:{Year} год\n\n";
        }
    }
}
