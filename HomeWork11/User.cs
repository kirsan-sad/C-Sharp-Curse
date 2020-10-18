using System;
using System.Collections.Generic;
using System.Text;

namespace dz11
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }

        public User()
        {
            Email = "mail" + new Random().Next(0, 100) + "@gmail.com";
            Password = "Pas" + new Random().Next(0, 100) + "word";
            Name = "Name" + new Random().Next(0, 100);
        }

        public void Message(object obj, AccountEventArgs e)
        {
            Console.WriteLine($"{Email}: {e.Message}");
        }
    }
}
