using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodleVideo3KurssiPaiv1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double dSumma = 0;
            string strSumma = "";
            string luku = "0";
            while (luku.Length > 0)
            {
                dSumma = dSumma + int.Parse(luku);
                Console.Write("Anna luku ({0}): ", dSumma.ToString());
                luku = Console.ReadLine();
            }
            Console.WriteLine("Lukujen summa on " + dSumma.ToString());
            Console.WriteLine();
            Console.WriteLine("Paina enter lopettaaksesi!");
            Console.ReadLine();
        }
    }
}
