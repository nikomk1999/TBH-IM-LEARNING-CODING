using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodleVideo3paiva2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean jatka = true;
            int i = 0, laskuri = 0;
            string etunimi, hakuPostinumero;
            string[,] henkiloTiedot = new string[100, 5];
            while (jatka)
            {
                Console.Write("Anna etunimi (X=lopettaa): ");
                etunimi = Console.ReadLine();
                if (etunimi.ToUpper() == "X")
                {
                    jatka = false;
                    break;
                }
                henkiloTiedot[i, 0] = etunimi;
                Console.Write("Anna sukunimi: ");
                henkiloTiedot[i, 1] = Console.ReadLine();
                Console.Write("Anna osoite: ");
                henkiloTiedot[i, 2] = Console.ReadLine();
                Console.Write("Anna postinumero: ");
                henkiloTiedot[i, 3] = Console.ReadLine();
                Console.Write("Anna postitoimipaikka: ");
                henkiloTiedot[i, 4] = Console.ReadLine();





                i++;
            }
            for (int j = 0; j < henkiloTiedot.GetLength(1); j++)
            {
                //nimi = nimet[j];
                if (henkiloTiedot[j, 0] != null)
                {
                    if (henkiloTiedot[j, 0].Length > 0)
                    {
                        Console.Write(henkiloTiedot[j, 0].PadRight(12).Substring(0, 12) + " ");
                        Console.Write(henkiloTiedot[j, 1].PadRight(20).Substring(0, 20) + " ");
                        Console.Write(henkiloTiedot[j, 2].PadRight(30).Substring(0, 30) + " ");
                        Console.Write(henkiloTiedot[j, 3].PadRight(5).Substring(0, 5) + " ");
                        Console.WriteLine(henkiloTiedot[j, 4].PadRight(30).Substring(0, 30) + " ");
                    }
                }
            }
            Console.WriteLine("ppostinumerohaku");
            Console.Write("Anna haettavan henkilön Postinumero: ");
            hakuPostinumero = Console.ReadLine();

            for (int k = 0; k < henkiloTiedot.GetLength(1); k++)
            {
                if (henkiloTiedot[k, 3] == hakuPostinumero)
                {
                    Console.Write("Etunimi: " + henkiloTiedot[k, 0] + " Sukunimi: " + henkiloTiedot[k,1] + " Osoite: " + henkiloTiedot[k, 2] + " Postinumero: " + henkiloTiedot[k, 3] + " Postitoimipaikka: " + henkiloTiedot[k, 4] + "\n");
                    laskuri++;
                }
            }
            Console.WriteLine("henkilöhaku suoritettu, {0} riviä löydetty postinumerolla {1} !", laskuri.ToString(), hakuPostinumero);
            Console.WriteLine("paina enter sulkeaksi ohjelma");
            Console.ReadLine();
        }
    }
}
