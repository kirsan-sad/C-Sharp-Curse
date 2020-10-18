using System;
using System.Collections.Generic;
using Stutents;

namespace Groups
{
    public class Group
    {
        List<Stutent> stud = new List<Stutent>();

        public Group (params Stutent[] student)
        {
            foreach (var item in student)
            {
                stud.Add(item);
            } 
        }

        public void allAsssessments()
        {
            foreach (var item in stud)
            {
                Console.WriteLine($"Оценки студента {item.LastName} {item.FirstName}:");
                foreach (var rang in item.Asssessments)
                {
                    Console.WriteLine(rang);
                }

            }
        }

        public void averageScoreAll()
        {
            foreach (var item in stud)
            {
                Console.WriteLine($"Средний балл студента {item.LastName} {item.FirstName}: {item.averageScore()}");
            }
        }
    }
}
