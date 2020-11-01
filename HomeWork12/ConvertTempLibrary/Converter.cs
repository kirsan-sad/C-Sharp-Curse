using System;

namespace ConvertTempLibrary
{
    public class Converter
    {
        static public double  CurrentFahrenheitValue { get; set; }
        static public double CurrentСelsiusValue { get; set; }

        static public void FromСelsiusToFahrenheit(double CTemp)
        {
            CurrentFahrenheitValue = (CTemp * 9 / 5) + 32;
        }

        static public void FromFahrenheitToСelsius (double FTemp)
        {
            CurrentСelsiusValue = (FTemp - 32) * 5 / 9;
        }

    }
}
