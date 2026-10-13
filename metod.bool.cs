using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hazflist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> bazi = new List<string>();
            bazi.Add("evil");
            bazi.Add("driver");
            string hazfbazi = "evil";
            bool result = HazfBazi(bazi, hazfbazi);
           
            if (result==true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("bazi " + hazfbazi + " hazf shod");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("bazi vojod nadarad");
            }

            Console.ReadKey();
        }
        public static bool HazfBazi(List<string> bazi, string hazfbazi)
        {
            if(bazi.Contains(hazfbazi))
            {
                bazi.Remove(hazfbazi);

                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
