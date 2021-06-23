using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle3PVosa13
{
    class Program
    {
        static void Main(string[] args)
        {
            string auto = "", jarj = "";
            List<string> Autot = new List<string>();
            Console.Write("Anna autojen merkit tai x lopettaaksesi: ");
            while (auto.ToUpper() != "X")
            {
                Console.Write("Auton merkki: ");
                auto = Console.ReadLine();
                if (auto.ToUpper() != "X")
                {
                    Autot.Add(auto);
                }
                
            }
            Console.WriteLine("haluatko nousevassa (n) vai laskevassa (l) järjestyksessä");
            jarj = Console.ReadLine().ToUpper();
            if (jarj == "N")
            {
                Autot.Sort();
            }
            else
            {
                Autot.Reverse();
            }


            Console.WriteLine("tallensit nämä autot:");

            for (int i = 0; i < Autot.Count; i++)
            {
                Console.WriteLine(Autot[i]);
            }
            Console.ReadLine();
        }
    }
}
