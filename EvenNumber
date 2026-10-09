sing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = new List<int> { 5, 12, 8, 21, 3, 47, 90, 3,34 };

            List<int> evenNumbers = GetEventNumber(inputList);

            Console.WriteLine("Even number are:");
            foreach(int num in evenNumbers)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
        public static List<int> GetEventNumber(List<int> inputList)
        {
            List<int> result = new List<int>();

            foreach (int num in inputList)
            {
                if (num % 2 == 0)
                {
                    result.Add(num);
                }

            }
            return result;
        }
    }
}
 
