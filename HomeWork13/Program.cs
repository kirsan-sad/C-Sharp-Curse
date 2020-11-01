using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

#region Условие задачи
//Создать файлик json на сайте.Json файл должен содержать бренд машины,
//модель, год выпуска(datetime), количество пройденных километров.
//начальная цена, цена сейчас(объектов должно быть не менее 100).

//Посчитать на сколько подешевеет машина через n лет.Т.е.нужно узнать на
//сколько машина дешевеет в год и умножить на число, которое пользователь
//вводит в консоли (n – количество лет). Плюс посчитать какой пробег будет у
//машины к этому времени.Дальше записать в файлик построчно следующую
//информацию: бренд, модель, год выпуска, на сколько подешевеет машина
//(если ушли в минут – пишем ваша машина утилизирована), и какой пробег у
//машины(если машина уже утилизирована, то пишем «Ваша машина
//пробежала БЫ … в 2026 году (тут используем формат дат. Почитать вот
//https://metanit.com/sharp/tutorial/19.2.php)».
#endregion

namespace dz13
{
    class Program
    {
        public static string path = Path.Combine(Directory.GetCurrentDirectory(), "cars.json");
        public static string pathTxt = Path.Combine(Directory.GetCurrentDirectory(), "newcars.txt");
        static void Main(string[] args)
        {
            List<NewCars> carsList = new List<NewCars>();

            var serializer = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.Indented
            };

            using (var sr = new StreamReader(path))
            using (var jr = new JsonTextReader(sr))
            {
                var newCar = serializer.Deserialize<List<Cars>>(jr);

                Console.WriteLine($"Данные загружены\nВведите колличество лет для пересчета пробега и падения в цене");
                int year = Convert.ToInt32(Console.ReadLine());

                foreach (var car in newCar)
                {
                    car.getCost(year);
                    car.getMileage(year);
                    carsList.Add(new NewCars { Model = car.Model, Brand = car.Brand, Year = car.Year, Cost = car.Cost, NewMileage = car.NewMileage});
                }

                Console.WriteLine("Новый список машин сформирован");

                using (var sw = new StreamWriter(pathTxt))
                {
                    foreach (var car in carsList)
                    {
                        sw.WriteLine($"Марка: {car.Brand}");
                        sw.WriteLine($"Модель: {car.Model}"); ;
                        sw.WriteLine($"Год выпуска: {car.Year.ToString("yyyy")}");
                        sw.WriteLine(car.Cost);
                        sw.WriteLine(car.NewMileage);

                        sw.WriteLine();
                    }
                }
                Console.WriteLine("Новый список сохранен");
            }
        }
    }
}
