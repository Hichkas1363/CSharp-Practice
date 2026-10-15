sing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sazandeh2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Car> Mashinha = new List<Car>();
            Mashinha.Add(new Car("samand"  ,  1400));
            Mashinha.Add(new Car("Ferari"  ,  2025));
            Mashinha.Add(new Car("Porseh"  ,  2026));
         
            foreach(Car c in Mashinha)
            {
                Console.WriteLine("Model" +" "+ c.Model + " " + c.Year);
            }

            Console.ReadKey();
        }
        public class Car
        {
            public string Model;
            public int Year;
            public Car(string model, int year)
            {
                Model = model;
                Year = year;
            }
        }
    }
}
