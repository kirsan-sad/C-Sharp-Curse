using System;

namespace dz6
{
    #region Условия
    // Создать класс с именем Rectangle.
    // В теле класса создать два поля, описывающие длины сторон double side1, side2.   
    // Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого поля side1 и side2 инициализируются значениями аргументов.
    // Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр прямоугольника - double PerimeterCalculator().  
    // Создать два свойства double Area и double Perimeter с одним методом доступа get.
    // Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит на экран периметр и площадь.
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ширину прямоугольника:");
            int side1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите длину прямоугольника:");
            int side2 = Convert.ToInt32(Console.ReadLine());

            var rec1 = new Rectangle(side1, side2);

            rec1.AreaCalculator();
            Console.WriteLine($"Площадь прямоугольника:{rec1.Area}");

            rec1.PerimeterCalculator();
            Console.WriteLine($"Периметр прямоугольника:{rec1.Perimeter}");

            Console.ReadLine();
        }
    }
}
