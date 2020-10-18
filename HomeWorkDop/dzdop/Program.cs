using System;
using Stutents;
using Groups;

namespace dzdop
{
    #region
      //Ввести с клавиатуры число n большее 0. Вывести на экран все числа из диапазона от 0 до n,
      //которые являются простыми.Продемонстрировать использование операторов for, break, continue.

      //Изменить программу - вместо цикла for использовать цикл while.

      //Простое число — целое положительное число, имеющее ровно два различных целых
      //положительных делителя — единицу и самого себя. Другими словами, число x является простым,
      //если оно больше 1 и при этом делится без остатка только на 1 и на x.К примеру, 5 — простое
      //число, а 6 не является простым числом, так как, помимо 1 и 6, также делится на 2 и на 3.
      
      //Найти строку в подстроке. Вводится строка и искомая подстрока.Вернуть индекс начала
      //подстроки.
      
      //Для заданного двоичного массива найдите максимальное количество последовательных единиц в
      //этом массиве.
      //Input: [1,1,0,1,1,1]
      //Output: 3
      
      //Реализовать в отдельной сборке (статья о том как создавать отельные сборки)
      //1. класс Студент
      //Поля: имя, фамилия, оценки(массив int)
      //Методы: почитать средний балл, вывести оценки студента
      //2. класс Группа
      //Поля: список студентов
      //Методы: вывести средний балл каждого студента, вывести оценки каждого студента
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            #region простое число через for
            //Console.WriteLine("Введите любое число больше 0");
            //var end = Convert.ToInt32(Console.ReadLine());

            //for (int i = 2; i < end; i++)
            //{
            //    if (i % 2 != 0 || i == 2 || i == 3 || i == 5)
            //    {
            //        if (i % 3 == 0 && i != 3) continue;
            //        if (i % 5 == 0 && i != 5) continue;
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region простое число через while
            //Console.WriteLine("Введите любое число больше 0");
            //var end = Convert.ToInt32(Console.ReadLine());
            //var i = 1;

            //while (true)
            //{
            //    i++;
            //    if (i % 2 != 0 || i == 2 || i == 3 || i == 5)
            //    {
            //        if (i % 3 == 0 && i != 3) continue;
            //        if (i % 5 == 0 && i != 5) continue;
            //        Console.WriteLine(i);
            //    }
            //    if (i >= end) break;
            //}

            #endregion

            #region поиск индекса начала подстроки в строке
            //Console.WriteLine("Введите предложение:");
            //var str = Convert.ToString(Console.ReadLine());

            //Console.WriteLine("Введите искомое слово:");
            //var word = Convert.ToString(Console.ReadLine());

            //var ind = str.IndexOf(word);

            //Console.WriteLine(ind);
            #endregion

            #region максимальная последовательность едениц в массиве
            //int[] bin = new int[] { 0, 1, 0, 1, 1, 0, 0, 1, 1, 1, 1, 0, 1, 1, 1, 0};

            //var start = 0;
            //var max = 0;
            //var temp = 0;
            //foreach (var i in bin)
            //{
            //    if (i == 1)
            //    {
            //        start += 1;
            //        max = start;
            //        if (max > temp)
            //        {
            //            temp = max;
            //        }
            //    }
            //    if (i == 0) start = 0;
            //}
            //Console.WriteLine($"{temp}");
            #endregion

            #region студенты
            var s1 = new Stutent("Stive", "Larson", new int[] { 10, 5, 6, 10, 5});
            var s2 = new Stutent("David", "Brown", new int[] { 2, 4, 2, 7, 6});

            
            var sr = s1.averageScore();
            //Console.WriteLine($"Средний балл: {sr}"); //средний балл студента
            //s1.asssessments(); //все оценки студента

            var g1 = new Group(s1, s2);

            g1.allAsssessments(); //оценки всех студентов
            g1.averageScoreAll(); //средний балл всех студентов
            #endregion
        }
    }
}
