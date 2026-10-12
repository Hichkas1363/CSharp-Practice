sing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Games = new List<string>();

            for(int i=1; i<=3; i++)
            {
                Console.Write("name bazi " + i + "ro vared konid : ");
                string  bazi = Console.ReadLine();
                Games.Add(bazi);
            }

            Games.Sort();
            Console.WriteLine("\n-----Asami baziha------");

            foreach (string g in Games)
            {
                Console.WriteLine("\n    " + g);
            }

            Console.WriteLine("\nYek bazi ra braye hazf vared konid : ");
            string hazf = Console.ReadLine();
            if(Games.Contains(hazf))
            {
                Games.Remove(hazf);
                Console.WriteLine("bazi hazf shod");
            }
            else
            {
                Console.WriteLine("bazi dar list vojod nadarad");
            }
            Games.Remove(hazf);
          
            Console.WriteLine("\nTedad bazihaye bagimandeh bad az hazf" +" "+ Games.Count + " "+"adad");

            Console.WriteLine("\nyek bazi ra brate jostojo benevisid");

            string jostojo = Console.ReadLine();

            bool find = Games.Contains(jostojo);

            if (find==true)
            {
                Console.WriteLine("\nbazi dar list vojod dare");

            }
            else
            {
                Console.WriteLine("\nbazi dar list vojod nadard");
            }


            Console.ReadKey();
        }
       
    }
    
}
