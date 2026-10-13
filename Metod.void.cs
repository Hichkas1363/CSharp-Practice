using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodandlist
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> bazi = new List<string>();
            bazi.Add("fifa");
            bazi.Add("driver");
            bazi.Add("god");
            string namebazi = "fifa";
            serchBazi(bazi, namebazi);
            Console.ReadKey();
        }
        public static void serchBazi(List<string> bazi, string namebazi)
        {
                if (bazi.Contains(namebazi))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("bazi dar list vojod darad");

                }
                else
                {
                    Console.WriteLine("baiz dar list vojod nadad");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
            }        
    }
}
