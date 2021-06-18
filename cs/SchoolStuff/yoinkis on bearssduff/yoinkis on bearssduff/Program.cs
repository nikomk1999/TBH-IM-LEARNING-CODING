using System;
using System.Globalization;

namespace GetTrolled
{
    class Sukupuoli
    {
        public bool mies;
        public bool nainen
        {
            get { return !mies; }
            set { mies = !value; }
        }

        public Sukupuoli(bool mies)
        {
            this.mies = mies;
        }

        public static Sukupuoli Parse(string x)
        {
            return new Sukupuoli(x.ToUpper() == "M" || (x.ToUpper() == "N" ? false : throw new FormatException()));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("en-FI");
            DateTime today = DateTime.Now;

            Console.WriteLine("Henkilötietosovellus, versio 1.00.00. Tänään on: " + today.ToString("d", culture));

            string nimi = Kysely("anna nimesi: ");
            Sukupuoli sukupuoli = Kysely("anna sukupuolesi (M/N): ", Sukupuoli.Parse, "Se ei ole M eikä N, idiootti");
            string email = Kysely("anna sähköpostisi: ");
            string phonenumber = Kysely("anna puhelinnumerosi: ");
            int age = Kysely("anna ikäsi: ", int.Parse, "se ei ole kelvollinen ikä. Yritä uudelleen");
            string osoite = Kysely("anna osoitteesi: ");
            string postipaikka = Kysely("anna postitoimituspaikka: ");
            string postinumero = Kysely("anna postinumerosi: ");

            string agegroup =
                age < 7 ? "alle kouluikäinen" :
                age < 18 ? "alaikäinen" :
                age < 66 ? "eläkeläinen" :
                           "täysikäinen";

            string tervehdys = $"päivää {nimi}! olet: {age}v";

            Console.WriteLine($"{tervehdys} olet {agegroup}");
            Console.WriteLine("osoitetiedot ovat...");
            Console.WriteLine(osoite);
            Console.WriteLine(postipaikka);
            Console.WriteLine(postinumero);

            if (sukupuoli.mies)
            {
                Console.WriteLine("Mitä jäbä duunaa?");
            }
            else
            {
                Console.WriteLine("Mitä mimmi puuhaa?");
            }

            Console.ReadLine();
        }

        private static string Kysely(String kysymys)
        {
            Console.WriteLine(kysymys);
            return Console.ReadLine();
        }

        private static T Kysely<T>(String kysymys, Func<String, T> muokkaaja, string huutaa)
        {
            Console.WriteLine(kysymys);
            while (true)
            {
                try
                {
                    return muokkaaja(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine(huutaa);
                }
            }
        }
    }
}