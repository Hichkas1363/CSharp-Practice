using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerchArry
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] score = { 15, 8, 12, 8, 20, 7, 14 };
            SerchScor(score);

            double[] number = {10,8,12,8,20,7,14 };
            double result = averageScore(number);
            Console.WriteLine("miyangin nomerat are :"+ result);

            int[]  numbers ={12,16,5,4,85,25,45,216,2,58,4 };
            int maxresult = Maximum(numbers);
            Console.WriteLine("Bozorgtarin add is :" + maxresult);

            int[] arr = {3,5,2,3,14,5,3,3,54,3,45,3,554,3 };
            int target = 3;
            int serchresult = serchnumber(arr,3);
            Console.WriteLine("Adade" +" "+ target +" "+ serchresult +" " +"bar tekrar shode");

            int[] arr2 = {10,20,10,30,10};
            int natijeh = maxindex(arr2, 10);
            Console.WriteLine("natijeh serch index :" + natijeh);

            Console.ReadKey();


        }

        public static void SerchScor(int [] Score)
        {
            int Count = 0;

            Console.WriteLine("list nomeray mardodiya");

            foreach (int scor in Score)
            {
                if(scor<10)
                {
                    Console.WriteLine(scor);
                    Count++;
                }
            
            }

            Console.WriteLine("Tedad mardodiya :" + Count);
        }

        public static double averageScore(double[] number)
        {
            double  sum  = 0;
            foreach(double  n in number)
            {
                sum += n;
            }

            double averag = sum / number.Length;
            return averag;
        }

        public static int Maximum(int[] numbers)
        {
            int max = 0;
            foreach (int n in numbers)
            {
                if (max<n)
                {
                    max = n;
                }

            }
            return max;
        }

        public  static int serchnumber(int[] arr , int target)
        {
            int count = 0;
            foreach(int a in arr)
            {
                if(a==target)
                {
                   count++;
                }
            }

            return count;
        }

     

       public static int maxindex(int[] arr2, int target)
        {
            int lastindex = -1;
            for (int i =0; i<arr2.Length; i++)
            {
                if (target == arr2[i]) ;
                {
                    lastindex = i;

                }
            }

            return lastindex;
        }

    }

}
         
