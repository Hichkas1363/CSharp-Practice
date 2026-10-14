using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ژمشسس
{
    class Program
    {
        static void Main(string[] args)
        {
            person person1 = new person();
            person1.Name = "Ali";
            person1.Age = 25;
            person1.moarefi();
            person1.BarresiSen();


            person person2 = new person();
            person2.Name = "Reza";
            person2.Age = 32;
            person2.moarefi();
            person2.BarresiSen();
            Console.ReadKey();


        }
    }

    class person
    {
        public string Name;
        public int Age;
        public void moarefi()
        {
            Console.WriteLine("Salam man "+" "+ Name +" "+ "hastam va"+" "+ Age + " sal daram");
        }

        public void BarresiSen()
        {
            if(Age>=30&&Age<=50)
            {
                Console.WriteLine(Name+" "+"Dar sen "+ " "+ Age +" " + "salegi Bozorgsal hast");
            }
            else
            {
                Console.WriteLine(Name+" " +"dar sen "+" "+ Age +" " + " salegi javan hast");
            }

        }
    }
}
