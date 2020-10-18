using System;

namespace dz7
{
    #region условия
       //Задание 1
       //Создать абстрактный базовый класс с виртуальной функцией - объем.
       //Создать производные классы: параллелепипед, пирамида, тетраэдр, шар со
       //своими функциями объема.
       //Для проверки определить массив ссылок на абстрактный класс, которым
       //присваиваются адреса различных объектов.
       //Объем параллелепипеда - V= xyz(x, y, z - стороны), пирамиды: V= xyh(x, y, -
       //стороны, h - высота), тетраэдра: V= a3 * Sqrl(2) / 12, шара: V= 4 / 3 * pi * R3
       
       //Задание 2
       //Выполнить предыдущее задание с использованием интерфейсов.
       
       //Задание 3
       //Создать класс Converter.
       //В теле класса создать пользовательский конструктор, который принимает два
       //вещественных аргумента, и инициализирует поля, соответствующие курсу 2-х
       //основных валют, по отношению к рублю.
       //Написать программу, которая будет выполнять конвертацию из рубля в одну
       //из указанных валют, также программа должна производить конвертацию из
       //указанных валют в рубль.
       //P.S.дополнительно можно подумать как решить Задание 3 с использованием
       //интерфейсов или абстрактных классов.
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            #region Задача 1,2 Объемы фигур
            //var p1 = new Pyramid(30, 10);
            //var t1 = new Tetrahedron(20);
            //var b1 = new Ball(15);
            //var par1 = new Parallelepiped(10, 15, 20);


            ////Figure[] figureArrey = new Figure[] {p1, t1, b1, par1}; через абстрактный класс
            //IFigure[] figureArrey = new IFigure[] { p1, t1, b1, par1 }; //через интерфейс

            //foreach (var item in figureArrey)
            //{
            //    var res = item.Volume();
            //    Console.WriteLine(res);
            //}
            #endregion

            #region Задача Конвертер
            var kursUsd = 2.61;
            var kursEur = 3.07;

            var myConverter = new Converter(kursUsd, kursEur);

            Console.WriteLine("Выберите валюту в которую хотите обменять:\nЕсли долары введите 1, если евро введите 2, если рубль нажмите 3.");
            var selection = Convert.ToInt32(Console.ReadLine());

            var sum = 0;

            switch (selection)
            {
                case 1:
                    Console.WriteLine("Вы выбрали долары. Введите сумму для обмена:");
                    sum = Convert.ToInt32(Console.ReadLine());

                    myConverter.Convert(Converter.Currency.Usd, sum);
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали евро. Введите сумму для обмена:");
                    sum = Convert.ToInt32(Console.ReadLine());

                    myConverter.Convert(Converter.Currency.Eur, sum);
                    break;
                case 3:
                    Console.WriteLine("Вы выбрали рубли. На какую валюту хотите обменять?\nЕсли долары введите 1, если евро введите 2");
                    var cur = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите сумму для обмена:");
                    sum = Convert.ToInt32(Console.ReadLine());

                    if (cur == 1) myConverter.ConvertRub(Converter.Currency.Usd, sum);

                    else if (cur ==2) myConverter.ConvertRub(Converter.Currency.Eur, sum);

                    else Console.WriteLine("Вы ввели неизвестную команду!");
                    break;
                default:
                    Console.WriteLine("Вы ввели неизвестную команду!");
                    break;
            }
            #endregion
        }
    }
}
