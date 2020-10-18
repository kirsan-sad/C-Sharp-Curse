using System;

namespace dz6._2
{
    #region
    // Создать класс Book.Создать классы  Title, Author и Content, каждый из которых должен содержать одно строковое поле и метод void Show().  
    // Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
    // Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и содержание.
    // Как вывести разными цветами на консоль - загуглите!
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введие название книги:");
            var title = Console.ReadLine();

            Console.WriteLine("Введие автора книги:");
            var author = Console.ReadLine();

            Console.WriteLine("Введие описание:");
            var cont = Console.ReadLine();

            var book1 = new Book(title, author, cont);

            book1.Show();

            Console.ReadKey();
        }
    }
}
