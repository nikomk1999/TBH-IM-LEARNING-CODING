using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle_tehtävä_koodi
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("en-FI");
            DateTime today = DateTime.Now;
            string tervehdys;
            string nimi;
            string osoite;
            string postipaikka;
            string postinumero;
            string agegroup;
            string gender;
            string email;
            string phonenumber;
            //string total;
            int age = 0;


            Console.WriteLine("Henkilötietosovellus, versio 1.00.00. Tänään on: " + today.ToString("d", culture));
            Console.WriteLine("anna nimesi: ");
            nimi = Console.ReadLine();
            Console.WriteLine("anna sukupuolesi (M/N): ");
            gender = Console.ReadLine();
            Console.WriteLine("anna sähköpostisi: ");
            email = Console.ReadLine();
            Console.WriteLine("anna puhelinnumerosi: ");
            phonenumber = Console.ReadLine();
            Console.WriteLine("anna ikäsi: ");
            age = int.Parse(Console.ReadLine());
            if (age < 7)
            {
                agegroup = "olet alle kouluikäinen";
            } else if (age < 18)
            {
                agegroup = "olet alaikäinen";
            }
            else if (age < 66)
            {
                agegroup = "olet eläkeläinen";
            } else
            {
                agegroup = "olet täysikäinen";
            }


            Console.WriteLine("anna osoitteesi: ");
            osoite = Console.ReadLine();
            Console.WriteLine("anna postitoimituspaikka: ");
            postipaikka = Console.ReadLine();
            Console.WriteLine("anna postinumerosi: ");
            postinumero = Console.ReadLine();
            tervehdys = "päivää " + nimi + '!' + " olet: " + age.ToString() + 'v';
            Console.WriteLine(tervehdys + ' ' + agegroup);
            Console.WriteLine("osoitetiedot ovat...");
            Console.WriteLine(osoite);
            Console.WriteLine(postipaikka);
            Console.WriteLine(postinumero);

            if (gender.ToUpper().Substring(0, 1) == "M")
            {
                Console.WriteLine("Mitä jäbä duunaa?");
            }
            else if (gender.ToUpper().Substring(0, 1) == "N")
            {
                Console.WriteLine("Mitä mimmi puuhaa?");
            }

            //total = (nimi + osoite + postipaikka + postinumero + gender + email + phonenumber + age);
            //Console.WriteLine("merkkien määrä yhteensä: " + total.Length);
            Console.ReadLine();



        }
    }
}
