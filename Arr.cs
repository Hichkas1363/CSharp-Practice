using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Findmaxarr
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = 5;
            int[] number = { 1, 1, 2, 30, 5, 4, 2, 5, 3 };
            int result = Findmaxarr(number, target);
            if (result != -1)
            {
                Console.WriteLine("inde peda shod :" + result);
                Console.WriteLine("megdar an khaneh :" + number[result]);
            }
            else
            {
                Console.WriteLine("hich aadadi bozorgtar az target peda nashod");
            }

            Console.ReadKey();
        }
        public static int Findmaxarr(int[] number, int target)
        {
            int findnumber = -1;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] > target)
                {
                    findnumber = i;
                    break;
                }

            }
            return findnumber;
            
        }
    }
}
