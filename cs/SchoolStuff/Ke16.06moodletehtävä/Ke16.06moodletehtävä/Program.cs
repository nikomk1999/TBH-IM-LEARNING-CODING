using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ke16._06moodletehtävä
{
    class Program
    {
        static void Main(string[] args)
        {
            string format = "dd.MM.yyyy HH:mm:ss";
            CultureInfo kultuuri = CultureInfo.InvariantCulture;

            DateTime parsiPaivamaara(string pvm)
            {
                return DateTime.ParseExact(pvm, format, kultuuri);
            }




            Double aikaEro = 0;
            string aikaA;
            string aikaB;
            DateTime aikaAA;
            DateTime aikaBB;
            string uudelleen = "Y";

            while (uudelleen.ToUpper().Substring(0, 1) == "Y")
            {
                Console.WriteLine("anna ensimmäinen päiväys muodossa \"PP.KK.YYYY HH:mm:ss\"");
                aikaA = Console.ReadLine();
                Console.WriteLine("anna toinen päiväys muodossa \"PP.KK.YYYY HH:mm:ss\"");
                aikaB = Console.ReadLine();

                try
                {
                    aikaAA = parsiPaivamaara(aikaA);
                    aikaBB = parsiPaivamaara(aikaB);
                }
                catch (Exception e)
                {
                    Console.WriteLine("kirjoitatko uudelleen " , e.ToString());
                    continue;
                }


                aikaEro = aikaAA.Subtract(aikaBB).TotalMinutes; //days on päiviä varten
                Console.WriteLine("Päivämäärien/-aikojen erotus on " + aikaEro.ToString() + " minuuttia");

                Console.WriteLine("Haluatko pelata uudelleen? \"Y/y/yes\" muussa tapauksessa anna mikätahansa muu kirjain");
                uudelleen = Console.ReadLine();

            }

        }
    }
}
