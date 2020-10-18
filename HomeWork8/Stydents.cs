using System;
using System.Collections.Generic;
using System.Text;

namespace dz8
{
    public class Stydent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Stydent (string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }


    }
}
