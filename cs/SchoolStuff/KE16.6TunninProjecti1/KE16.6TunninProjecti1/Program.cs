using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KE16._6TunninProjecti1
{
    class Program
    {
        static void Main(string[] args)
        {
            int esimerkkiFunktio(int a, int b)
            {
                return a + b;
            }

            int tulos = esimerkkiFunktio(1, 1);

            // <funktion palautustyyppi> <funktion nimi>() {    }


            Console.WriteLine(tulos);
            Console.ReadLine();
        }
    }
}
