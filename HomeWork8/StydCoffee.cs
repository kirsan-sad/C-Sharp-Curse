using System;
using System.Collections.Generic;
using System.Text;

namespace dz8
{
    public class StydCoffee
    {
        //Stack<Stydent> stydents = new Stack<Stydent> { };
        //Queue<Stydent> stydents = new Queue<Stydent> { };
        MyQueue<Stydent> stydents = new MyQueue<Stydent> { };

        public void takeCofee(Stydent s)
        {
            //stydents.Enqueue(s); //Для очереди
            //stydents.Push(s); //Для стека
            stydents.Add(s); //Для своего связного списка

            Console.WriteLine($"Студент {s.FirstName} добавлен");
        }

        public void showCoffee()
        {
            Console.WriteLine("Студенты получившие кофе:");
            foreach (var item in stydents)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} {item.Age}");
            }
        }
    }
}
