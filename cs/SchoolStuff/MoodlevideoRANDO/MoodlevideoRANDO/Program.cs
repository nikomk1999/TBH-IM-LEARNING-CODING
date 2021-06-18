using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodlevideoRANDO
{
    class Program
    {
        static void Main(string[] args)
        {

            Boolean lopeta = false;
            Console.WriteLine("Tervetulkoa rando geniin");
            while (lopeta != true)
            {
                Console.WriteLine("Haetaan seuraavat rand luvut...");
                randomLuvut();
                Console.WriteLine("Haetaanko luv uudelleen K=kyllä/E=ei");
                if (Console.ReadLine().ToUpper() == "E") lopeta = true;
                
            }
            randomLuvut();

            //silmukka päättyy
            //Console.ReadLine();

        }

        private static void randomLuvut()
        {
            int rLUKU = 0, i = 0;
            Random arpa = new Random();
            while (i < 100)
            {
                rLUKU = arpa.Next(1, 3000);
                Console.WriteLine("Silmukan kieroksella {1} randomluku on {0}", rLUKU.ToString(), (i + 1).ToString());
                //kasvattaa silmukkaa 1 joka kerta
                i++;

            }
        }
    }
}
