using System;

namespace dz
{
    #region Условие
    // Рассчитать выплаты по кредиту
    // Рассчитать месячные выплаты(m) и суммарную выплату(s) по кредиту.
    // О кредите известно, что он составляет N рублей, берется на Y лет, под P процентов.

    // Сумма кредита(руб.) : 1000000
    // Период(количество лет) : 20
    // Процент: 15
    // Ежемесячные выплаты: 13313 руб.
    // Всего будет выплачено: 3195230 руб.

    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            const decimal persent = 15;

            Console.WriteLine("Введите сумму кредита:");
            decimal credit = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Введите срок кредита (лет):");
            decimal time = (Convert.ToDecimal(Console.ReadLine()) * 12);

            decimal permonth = (credit / 100 * persent) / 12; //переплата процентов месячная
            decimal paymonth = credit / time + permonth; //месячный платеж
            decimal osn = credit / time;  //основной платеж

            Console.WriteLine($"Годовой процент кредита:{persent}%.");

            decimal ost = 0;
            double pro = 0.15;
            decimal summ = 0;

            for (int i = 0; i < time; i++)
            {
                ost = osn + ((credit - (osn * i)) * (decimal)pro)/12; //платеж по проценту кредита
                summ += ost ;

                Console.WriteLine($"Месяц:{i + 1} - платеж составляет:{Math.Round(ost, 2)} р.");
            }

            Console.WriteLine($"Итоговая сумма кредита с процентами: {Math.Round(summ, 2)} р.");

            Console.ReadLine();
        }
    }
}
