﻿using System;

namespace dz9
{
    #region
     //Создать класс Vehicle.

     //В теле класса создайте поля: координаты(это будет структура) и параметры средств передвижения(цена,
     //скорость, год выпуска).

     //Создайте 3 производных класса Plane, Саг и Ship.

     //Для класса Plane должна быть определена высота и количество пассажиров. (это доп поля в классе Plane)

     //Для класса Ship — количество пассажиров и порт приписки. (доп поля в классе Ship)

     //Написать программу, которая выводит на экран информацию о каждом средстве передвижения.

     //Используйте переопределение ToString(). Переопределить метод Equals который будет своим для каждого
     //класса.

     //PS.Когда мы пишем obj1 == obj2 – вызывается Equals. Поставьте брекпоинт и посмотрите это.
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Plane(100100, 120, 300, 2001) {Passengers = 120, Height = 120};
            var c1 = new Car(111090, "Bmw", "X7", 10, 200, 2010);
            var s1 = new Ship(1900200, 200, "Сидней", 700, 120, 2000);

            Console.WriteLine($"{p1}{c1}{s1}");
        }
    }
}
