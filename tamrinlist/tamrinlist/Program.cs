using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrinlist
{
    class Program
    {

        public static void PrintNumbrt(List<int> number , int target)
        {
            Console.WriteLine("Number Maximum To 10");
            foreach (int n in number)
            {
                if(n>target)
                {
                    Console.Write(","+n);
                }
            }
        }

        static void Main(string[] args)
        {

            List<int> number = new List<int>();
            number.Add(12); number.Add(16); number.Add(6); number.Add(45);
            int target = 10;
            PrintNumbrt(number, target);
            Console.ReadKey();
        }
    }
}
