using System;
using System.Collections.Generic;

namespace dz10
{
    #region Условия задачи
     //Создайте класс DocumentWorker.

     //В теле класса создайте три метода OpenDocument(), EditDocument(), SaveDocument().

     //В тело каждого из методов добавьте вывод на экран соответствующих строк: &quot;Документ открыт&quot;,
     //&quot;Редактирование документа доступно в версии Про&quot;, &quot;Сохранение документа доступно в версии
     //Про&quot;.

     //Создайте производный класс ProDocumentWorker.

     //Переопределите соответствующие методы, при переопределении методов выводите следующие строки:
     //&quot; Документ отредактирован&quot;, &quot;Документ сохранен в старом формате, сохранение в остальных
     //форматах доступно в версии Эксперт&quot;.

     //Создайте производный класс ExpertDocumentWorker от базового класса ProDocumentWorker.
     //Переопределите соответствующий метод. При вызове данного метода необходимо выводить на экран
     //&quot; Документ сохранен в новом формате&quot;.

     //В теле метода Main() реализуйте возможность приема от пользователя номера ключа доступа pro и exp.
     
     //Если пользователь не вводит ключ, он может пользоваться только бесплатной версией(создается
     //экземпляр базового класса), если пользователь ввел номера ключа доступа pro и exp, то должен создаться
     //экземпляр соответствующей версии класса, приведенный к базовому - DocumentWorker.

     //Ключи будут хранится в коллекциях proKeys и expKeys.Для ключей используем Guid.NewGuid().ToString();

     //Входной ключ будем проверять в одной из коллекций и если он использован – удаляем его.

     //Переопределяем все возможные базовые методы на ваше усмотрение
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            var doc = new DocumentWorker();
            DocumentWorker pro = new ProDocumentWorker();
            DocumentWorker exp = new ExpertDocumentWorker();


            var proKeys = new List<string>();
            Console.WriteLine("Ключи PRO\n");

            for (int i = 0; i < 3; i++)
            {
                proKeys.Add(Guid.NewGuid().ToString());
                Console.WriteLine(proKeys[i]);
            }

            var expKeys = new List<string>();
            Console.WriteLine("\nКлючи EXPERT\n");

            for (int i = 0; i < 3; i++)
            {
                expKeys.Add(Guid.NewGuid().ToString());
                Console.WriteLine(expKeys[i]);
            }

            Console.WriteLine("\nВведите ключ");
            var search = Convert.ToString(Console.ReadLine());

            Console.Clear();

            if (proKeys.Contains(search))
            {
                Console.WriteLine("Ваш ключ PRO");
                proKeys.Remove(search);
                doc = pro;
            }

            else if (expKeys.Contains(search))
            {
                Console.WriteLine("Ваш ключ EXPERT");
                expKeys.Remove(search);
                doc = exp;
            }
            else
            {
                Console.WriteLine("Ключ пустой или не верный.\nВы используете ограниченную версию.");
            }

            Console.WriteLine("\nЧтобы открыть документ нажмите 1\nЧтобы редактировать нажмите 2\nЧтобы сохранить нажмите 3");
            var work = Convert.ToInt32(Console.ReadLine());

            switch (work)
                {
                    case 1:
                        doc.OpenDocument();
                        break;
                    case 2:
                        doc.EditDocument();
                        break;
                    case 3:
                        doc.SaveDocument();
                        break;
                    default:
                    Console.WriteLine("Неизвестная команда");
                        break;
                }

        }
    }
}
