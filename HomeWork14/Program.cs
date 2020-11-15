using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;

namespace dz14
{
    #region Задание
    //Представьте, что вы пишите приложение для автосалона и вам необходимо создать коллекцию автомобилей со следующими данными: 
    //Марка автомобиля, модель, год выпуска, цвет, цена.
    //А также вторую коллекцию с моделью автомобиля, именем покупателя и его номером телефона.
    //Коллекцию автомобилей и покупателей создаем с помощью https://www.mockaroo.com/ 
    //Потом берем рандомом инфу из первой коллекции, рандомом из второй и создаем коллекцию с моделью автомобиля, 
    //именем покупателя и его номером телефона (здесь используем JsonDeserializer и запись в файл)
    //Используя простейший LINQ запрос, выведите на экран информацию о:
    //покупателе одного из автомобилей и полную характеристику приобретенной ними модели.
    //количество автомобилей конкретной модели (используем GroupBy)
    //посчитать общую стоимость авто в автосалоне
    //машину с самым максимальным и минимальным годом выпуска
    //информацию о каждом покупателе и его автомобилях.
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            var cars = Helper.GetObjectsFromFile<Cars>("Cars.json");
            var customers = Helper.GetObjectsFromFile<Customer>("Customers.json");

            var carCustomers = from car in cars
                               join customer in customers
                               on car.Model equals customer.Model
                               select new
                               {
                                   car.Brand,
                                   car.Model,
                                   car.Color,
                                   car.Year,
                                   car.Cost,
                                   customer.Name,
                                   customer.Phone
                               };

            using (var sw = new StreamWriter("carCustomers.txt"))
            {
                foreach (var i in carCustomers)
                {
                    sw.WriteLine($"Имя покупателя: {i.Name}");
                    sw.WriteLine($"Модель приобретенной машины: {i.Model}");
                    sw.WriteLine($"Телефон покупателя: {i.Phone}\n");
                }

                Console.WriteLine("Файл создан");
            }

            var selected = carCustomers.Where(x => x.Name.Contains("Lyndy"));

            foreach (var i in selected)
            {
                Console.WriteLine($"Имя покупателя: {i.Name}");
                Console.WriteLine($"Марка: {i.Brand}");
                Console.WriteLine($"Модель: {i.Model}");
                Console.WriteLine($"Цвет: {i.Color}");
                Console.WriteLine($"Год выпуска: {i.Year}");
                Console.WriteLine($"Цена: {i.Cost:N3}$");

            }

            var countCar = cars.GroupBy(x => x.Brand);

            foreach (var i in countCar)
            {
                Console.WriteLine($"Бренд: {i.Key}. В наличии: {i.Key.Count()} штук");
            }

            var allCarsCost = cars.Sum(x => x.Cost);

            Console.WriteLine($"Общая стоимость всех машин: {allCarsCost:N3}$");

            var minYear = cars.Min(x => x.Year);
            var oldest = cars.Where(x => x.Year == minYear).ToList();

            foreach (var i in oldest)
            {
                Console.WriteLine($"Самая старая машина {i.Brand} {i.Model} - {i.Year} года выпуска");
            }
            
            var maxYear = cars.Max(x => x.Year);
            var youngest = cars.Where(x => x.Year == maxYear).ToList();

            foreach (var i in youngest)
            {
                Console.WriteLine($"Самая новая машина {i.Brand} {i.Model} - {i.Year} года выпуска");
            }

            //Console.WriteLine($"Минимальный год выпуска: {oldest.} {minYear}г.\nМаксимальнй год выпуска: {maxYear}г.");

            var allCustomersWithCars = carCustomers.GroupBy(x => x.Name);

            foreach (var customer in allCustomersWithCars)
            {
                Console.WriteLine($"*****************\nПокупатель: {customer.Key}\n*****************\n");

                foreach (var i in customer)
                {
                    Console.WriteLine($"Марка: {i.Brand}\nМодель: {i.Model}\nЦвет: {i.Color}\nГод выпуска: {i.Year}\nЦена: {i.Cost:N3}$\n");
                }
            }
        }
    }
}
