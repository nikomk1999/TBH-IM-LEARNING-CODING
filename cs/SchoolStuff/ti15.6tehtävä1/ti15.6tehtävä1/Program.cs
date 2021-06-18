using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ti15._6tehtävä1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string uudelleen = "Y";

            while (true)//(uudelleen.ToUpper() == "Y")
            {
                int rINT = random.Next(1, 3001);
                int laskuri = 0;

                while (laskuri != rINT)
                {
                    laskuri++;
                }
                Console.WriteLine("kierrokisa mennyt: " + laskuri);
                Console.WriteLine("haluatko uuden kierroksen? (Y/N)");
                uudelleen = Console.ReadLine();

                if (uudelleen.ToUpper().Substring(0, 1) == "N" /*|| uudelleen.ToUpper() == "EN"*/)
                {
                    Console.WriteLine("Tnx for playing");
                    break;
                }

            }
            














        }
    }
}
