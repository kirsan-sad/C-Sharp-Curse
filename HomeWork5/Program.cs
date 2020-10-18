using System;

namespace dz5
{
    #region Условия
    // Самое длинное слово в строке и количество слов в строке
    // Вводится строка слов, разделенных пробелами.
    // Найти самое длинное слово и вывести его на экран.
    // Случай, когда самых длинных слов может быть несколько, не обрабатывать.

    //public static void LongestWordInString(string str)
    //{
        // Первый варинат не использовать какие либо методы из string
        // Второй варинт решить задачу с использованием встроенных в .NET
        // методов описанных в файле Strings.cs
    //}

    // В двумерном массиве в каждой строке все элементы, расположенные после максимального, заменить на 0.
    //public static void ReplacingElements(int[,] array)
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            #region самое длинное слово .Net
            //Console.WriteLine("Введите предложение");
            // string str = Console.ReadLine();

            //string[] s = str.Split();

            // string strMax = "";

            // foreach (var item in s)
            // {
            //     if (item.Length > strMax.Length)
            //     {
            //        strMax = item;                   
            //     } 
            // }
            // Console.WriteLine($"Самое длинное слово: {strMax}");
            #endregion

            #region самое длинное слово

            //Console.WriteLine("Введите предложение");
            //string s = Console.ReadLine();

            //int SpaceCount = 1;

            //foreach (char c in s)
            //    if (c == ' ') SpaceCount++;

            //string[] Words = new string[SpaceCount];

            //int j = 0;
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i] == ' ')
            //    {
            //        j++;
            //        continue;
            //    }

            //    {
            //        Words[j] += s[i];
            //    }
            //}

            //int MaxIndex = 0;
            //int MaxCount = 0;

            //for (int i = 0; i < SpaceCount; i++)
            //{
            //    if (Words[i].Length > MaxCount)
            //    {
            //        MaxCount = Words[i].Length;
            //        MaxIndex = i;
            //    }
            //}

            //Console.WriteLine($"Самое длинное слово:: {Words[MaxIndex]}");

            #endregion

            #region массивы
            Random _random = new Random();

            int[,] mass = new int[3, 5];

            for (int i = 0; i < mass.GetLength(0); i++)
            {
                int max = int.MinValue;
                int maxJ = 0;
                
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] = _random.Next(1, 100);
                    
                    if (mass[i, j] > max)
                    {
                       max = mass[i, j];
                       maxJ = j;  
                    }
                }
                
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    if (j > maxJ)
                    {
                        mass[i, j] = 0;
                    }
                }
            }


            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write(mass[i, j] + " ");
                }

                Console.WriteLine();
            }

            #endregion
            Console.ReadLine();       
        }
    }
}
