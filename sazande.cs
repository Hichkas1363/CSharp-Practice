using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("sara", 35);
            Console.WriteLine(" name " + " " + p1.Name + " " + " sen " + " " + p1.Age);
            Console.ReadKey();
        }
        public class Person
        {
            public string Name;
            public int Age;
            public Person(string namekarbar, int agekarbar)
            {
                Name = namekarbar;
                Age = agekarbar;

            }
        }
    }
}
