using System;

namespace Stutents
{
    public class Stutent
    {
        string _lastName;
        public string LastName
        {
            get
            {
            return _lastName;
            }
        }
        string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
        }
        int[] _asssessments;

        public int[] Asssessments
        {
            get
            {
                return _asssessments;
            }
        }

        public Stutent(string lastName, string firstName, int[] asssessments)
        {
            _lastName = lastName;
            _firstName = firstName;
            _asssessments = asssessments;
        }

        public void asssessments()
        {
            Console.WriteLine($"Оценки студента {_lastName} {_firstName}");
            foreach (var item in _asssessments)
            {
                Console.WriteLine(item);
            }
        }

        public double averageScore()
        {
            double sum = 0;
            foreach (var item in _asssessments)
            {
                sum += item;   
            }
            double res = sum / _asssessments.Length;

            return res; 
        }

    }
}
