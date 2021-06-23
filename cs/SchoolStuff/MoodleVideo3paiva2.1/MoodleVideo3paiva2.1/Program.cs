using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodleVideo3paiva2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean jatka = true;
            int i = 0;
            string nimi;
            string[] nimet = new string[100];
            while (jatka)
            {
                Console.Write("Anna etunimi (X=lopettaa): ");
                nimet[i] = Console.ReadLine();
                if (nimet[i].ToUpper() == "X") jatka = false;
                i++;
            }
            for (int j = 0; j < nimet.Length; j++)
            {
                nimi = nimet[j];
                if (nimi != null)
                {
                    if (nimi.Length > 0) Console.WriteLine(nimi);
                }
            }
            Console.WriteLine("paina enter sulkeaksi ohjelma");
            Console.ReadLine();



        }
    }
}
