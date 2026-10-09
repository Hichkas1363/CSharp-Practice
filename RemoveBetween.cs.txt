using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serchlist
{
    class Program
    {


        public static void RemoveBetween(List<int> number)
        {
              number.RemoveAll(n => n >= 20 && n <= 35);
            
        }

        static void Main(string[] args)
        {
            List<int> number = new List<int> {40,52,25,86,45 };
            RemoveBetween(number);
            Console.WriteLine("List jadid bad az hazf add :");
            foreach (int n in number)
            {
                Console.WriteLine(n);
            }
           Console.ReadKey();
            }


        }
    }
