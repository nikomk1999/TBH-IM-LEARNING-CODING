using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodleVideo3Paiva2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] taulukko1 = new int[] { 2000, 1, 5, 16, 77, 101, 44, 1324, 3234 };
            
            Console.WriteLine("yritä arvata luku");
            int arvaa = int.Parse(Console.ReadLine());

            for (int i = 0; i < taulukko1.Length; i++)
            {
                if (arvaa == taulukko1[i])
                {
                    Console.WriteLine("onnittelut voitit pelin!");
                }
                else
                {
                    Console.WriteLine("et valitettavasti arvannut lukua...");
                }
            }
            Console.WriteLine("paina enter");

            Console.ReadLine();
        }
    }
}
