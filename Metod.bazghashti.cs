using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzafeKardanBazi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> baziha = new List<string>();
            string namejadid = "godofwar";
            int tedad = EzafeKaradnBazi(baziha, namejadid);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("tedad kol baziha" + " " + tedad );
            Console.ReadKey();
        } 
        public static int EzafeKaradnBazi(List<string> baziha, string namejadid)
        {
            baziha.Add(namejadid);

            return baziha.Count;

        }
    }
}
