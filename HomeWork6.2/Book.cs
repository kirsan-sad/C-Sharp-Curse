using System;
using System.Collections.Generic;
using System.Text;

namespace dz6._2
{
    class Book
    {
        Title t1 = new Title();
        Author a1 = new Author();
        Content c1 = new Content();

        public Book (string title, string author, string content)
        {
            t1._title = title;
            a1._name = author;
            c1._cont = content;
            Console.WriteLine("Книга добавлена");
        }
        
        public void Show ()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            t1.Show();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            a1.Show();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            c1.Show();
            Console.ResetColor();
        }
        
    }
}
