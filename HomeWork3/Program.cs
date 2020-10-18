using System;

namespace dz3
{
    #region Условия
       //Посчитать сумму n-членов арифметической прогрессии.Для
       //вычисления an нужно взять алгоритм, который писали на занятии. Он
       //если в примерах кода в папке к 3-му заданию
       
       //По желанию
       
       //2. Дописать пример по подсчёту скидки с занятие чтобы зацикливался
       //ввод данных, и программа ожидала только число.
       //3. Написать программу, которая вычисляет сумму и произведение числа.
       //Предусмотреть случаи, когда пользователь вводить не число.Не нужно
       //зацикливать программу чтобы он ввел число просто аккуратно
       //обработать и выдать сообщение – “Вы ввели не число”
       //Пример:
       //Вводим – 456
       //Выводим – сумма 15 (4 + 5 + 6), произведение – 120 (4 * 5 * 6)
    #endregion
    class Program
    {
        static void Main(string[] args)
        {

            #region сумма членов прогрессии

            //Console.WriteLine("Введите начало прогрессиии:");
            //int start = int.Parse(Console.ReadLine());

            //Console.WriteLine("Введите шаг прогрессиии:");
            //int step = int.Parse(Console.ReadLine());

            //Console.WriteLine("Введите колличество членов:");
            //int count = int.Parse(Console.ReadLine());

            //int result = start + step * (count - 1);

            //int res2 = count * (start + result) / 2;

            //Console.WriteLine($"Сумма n-членов равна: {res2}");

            #endregion

            #region подсчет скидки

            //int cost;
            //bool check;
            //do
            //{
            //    Console.WriteLine("Введите цену товара");
            //    check = int.TryParse(Console.ReadLine(), out cost);
            //}
            //while (!check);

            //int count;
            //bool check2;
            //do
            //{
            //    Console.WriteLine("Введите количество товара");
            //    check2 = int.TryParse(Console.ReadLine(), out count);
            //}
            //while (!check2);

            //double sp = count * cost;
            //double discount = 0;

            //if (count > 100)
            //{
            //    discount = 0.1;
            //}
            //else if (count > 50)
            //{
            //    discount = 0.05;
            //}

            //sp -= sp * discount;

            //Console.WriteLine($"Цена со скидкой: {sp}");

            #endregion

            #region программа, которая вычисляет сумму и произведение числа

            Console.WriteLine("Введите число:");
            string s = Console.ReadLine();

            char[] ar = s.ToCharArray();

            var sum = 0;
            var mul = 1;

            for (int i = 0; i < ar.Length; i++)
            {
                char tmp = ar[i];
                int t = (int)Char.GetNumericValue(tmp);
                sum += t;
                mul *= t;
            }

            Console.WriteLine($"Сумма числа {s} равна: {sum}");
            Console.WriteLine($"Произведение числа {s} равно: {mul}");
            #endregion
        }
    }
}
