using System;
using System.Collections.Generic;
using System.Text;

namespace dz7
{
    public class Converter
    {
        public double KursUsd { get; set; }
        public double KursEur { get; set; }
        
        public Converter (double kursUsd, double kursEur)
        {
            KursUsd = kursUsd;
            KursEur = kursEur;
        }

        public enum Currency
        {
            Usd = 1,
            Eur
        }

        public void Convert (Currency kurs, double sum)
        {
            var result = 0.0;

            switch (kurs)
            {
                case Currency.Usd:
                    result = KursUsd * sum;
                    break;
                case Currency.Eur:
                    result = KursEur * sum;
                    break;
            }
            Console.WriteLine($"Вы получите: {result}");
        }

        public void ConvertRub(Currency kurs, double sum)
        {
            var result = 0.0;

            switch (kurs)
            {
                case Currency.Usd:
                    result = sum / KursUsd;
                    break;
                case Currency.Eur:
                    result = sum / KursEur;
                    break;
            }
            Console.WriteLine($"Вы получите: {result}");
        }

    }
}
