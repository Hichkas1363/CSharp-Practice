using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee E = new Employee("AlirezaRahimi", 200000);
            E.PrintInformation();

            Employee E1 = new Employee("Billgats");
            E1.PrintInformation();

            Console.ReadKey();
        }
        public class Employee
        {
            private decimal Hogog;
            public string Name { get; set; }

            public decimal hogog
            {
                get
                {
                    return hogog;
                }
                set
                {
                    if (value < 0)
                    {
                        hogog = 0;
                    }
                    else
                    {
                        hogog = value;
                    }
                }
            }

            public Employee(string NameEmployar) : this(NameEmployar, 1000000)
            {
            }

            public Employee(string nameemployar, decimal hogogemployar)
            {
                Name = nameemployar;
                Hogog = hogogemployar;
            }
            public void PrintInformation()
            {
                Console.WriteLine($"Name kaemand {Name} hast va hogog karman {Hogog} hast");

            }
        }
    }
}

    
