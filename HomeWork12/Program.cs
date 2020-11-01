using System;
using System.Reflection;

namespace dz12
{
    #region Условие задания
    //Создайте свою пользовательскую сборку, которая будет использовать для
    //работы с конвертером температуры
    //- (25 °C × 9/5) + 32 = 77 °F
    //- (100 °F − 32) × 5/9 = 37,778 °C
    //Подгрузить эту сборку динамически.
    //Вызвать метод FromСelsiusToFahrenheit =&gt; метод записывает результат в
    //свойства CurrentFahrenheitValue
    //Получить результат свойства CurrentFahrenheitValue
    //Вызвать метод FromFahrenheitToСelsius =&gt; метод записывает результат в
    //свойства CurrentСelsiusValue
    //Получить результат свойства CurrentСelsiusValue
    #endregion  

    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Assembly asm = Assembly.LoadFrom(@"C:\Users\User\Desktop\dz\dz12\ConvertTempLibrary\obj\Debug\netcoreapp3.1\ConvertTempLibrary.dll");
                
                var syperType = asm.GetType("ConvertTempLibrary.Converter");

                //var obj = Activator.CreateInstance(syperType);

                var methodConvertF = syperType.GetMethod("FromСelsiusToFahrenheit");
                var methodConvertC = syperType.GetMethod("FromFahrenheitToСelsius");

                methodConvertF.Invoke(null, new object[] { 30 });
                methodConvertC.Invoke(null, new object[] { 130 });

                var FTemp = syperType.GetProperty("CurrentFahrenheitValue");
                var CTemp = syperType.GetProperty("CurrentСelsiusValue");

                Console.WriteLine(FTemp.GetValue(null));
                Console.WriteLine(CTemp.GetValue(null));

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
