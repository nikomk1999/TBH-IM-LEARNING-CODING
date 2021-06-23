using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodletehtävä2
{
    class Program
    {
        static void Main(string[] args)
        {
            string stop = "";
            do
            {

                AikaLaskuri();
                Console.ResetColor();
                Console.WriteLine("haluatko pelata uudellen? \"N = ei\"");
                stop = Console.ReadLine().ToUpper().ToString().Substring(0);
            } while (stop != "N");

        }

        private static void AikaLaskuri()
        {
            Double aikaaikaJaljella = 0;
            int elinIanOdote = 0;
            string alkuAika = "", sp = "";
            string vuodetKuukaudetPaivat = "";
            DateTime syntymaAikaDT, elinianOdotusTD;
            DateTime tanaan = DateTime.Now;
            string formaatti = "dd.MM.yyyy";//HH:mm:ss
            CultureInfo kultuuri = CultureInfo.InvariantCulture;

            Console.WriteLine("kerro sukupuoli M/N");
            sp = Console.ReadLine().ToUpper();
            switch (sp)
            {
                case "M":
                    elinIanOdote = 78;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;

                case "N":
                    elinIanOdote = 84;
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    Console.WriteLine("virheewllinem vaöliuntas!");
                    elinIanOdote = 0;
                    break;
            }


            Console.WriteLine("Anna syntymäaika muodossa PP.KK.VVVV HH:mm:ss tt");
            alkuAika = Console.ReadLine();
            try
            {
                //alkuAika = Console.ReadLine();
                syntymaAikaDT = DateTime.ParseExact(alkuAika, formaatti, kultuuri);
                elinianOdotusTD = syntymaAikaDT.AddYears(elinIanOdote);
                aikaaikaJaljella = elinianOdotusTD.Subtract(tanaan).TotalDays; //days on päiviä varten
                DateTime paivat = new DateTime(new TimeSpan((int)aikaaikaJaljella + 1, 0, 0, 0).Ticks);
                vuodetKuukaudetPaivat = string.Format("{0} vuotta {1} kuukautta {2} päivää", paivat.Year - 1, paivat.Month - 1, paivat.Day - 1);
            }
            catch (Exception ee)
            {
                //Console.WriteLine("yeah for some reason it doesent like . so try , and enter it again!" + "\n" + " enter it like \"PP,KK,VVVV HH24:MI:SS\"");
                //alkuAika = Console.ReadLine();
                Console.WriteLine("Ohjelma ei onnistunut laskemaan päiväerotusta. Tarkista pvm-formaatti.");
                Console.WriteLine(ee.Message);
                aikaaikaJaljella = 0;
            }
            if (aikaaikaJaljella < 2)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Beep(200, 1000);
            }
            else if (aikaaikaJaljella < 20)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Green;
            }
            //syntymaAikaDT = DateTime.ParseExact(alkuAika, formaatti, kultuuri);
            //aikaEro = tanaan.Subtract(syntymaAikaDT).TotalHours; //days on päiviä varten
            Console.WriteLine("odotettua elinaikaa jäljellä " + vuodetKuukaudetPaivat + ".");
            Console.ReadLine();
        }
    }
}
