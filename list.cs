using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {

            int limit = 5;
            int[] number = { 2,10,4,25,8};
            List<int> result= Findmaxnumber(number, limit);
            Console.WriteLine("Adad bozorgtar az limit:");
            result.Sort();
            foreach (int n in result)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
        public static List<int> Findmaxnumber(int[] number, int limit)
        {
            List<int> result = new List<int>();
            foreach (int n in number)
            {
                if (n > limit)
                {
                    result.Add(n);
                   
                }
            }
            return result;
        }
    }
}
