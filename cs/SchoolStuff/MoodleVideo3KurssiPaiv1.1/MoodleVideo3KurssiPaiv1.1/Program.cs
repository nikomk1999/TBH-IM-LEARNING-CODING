using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MoodleVideo3KurssiPaiv1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string tiedosto2 = @"G:\projectsOwO\Git\TBH-IM-LEARNING-CODING\cs\FolderForRandoConfigs\moodleosa3paiv1.1\Lampotila2.txt"; //tapa 1
            string tiedosto = "G:\\projectsOwO\\Git\\TBH-IM-LEARNING-CODING\\cs\\FolderForRandoConfigs\\moodleosa3paiv1.1\\Lampotila.txt"; //tapa 2
            string aikaisempiArvo, uusiArvo;

            if (File.Exists(tiedosto2))
            {
                aikaisempiArvo = File.ReadAllText(tiedosto2);
                Console.WriteLine("lämpötila on: " + aikaisempiArvo);
            }
            else
            {
                Console.WriteLine("tervetuloa!");
            }
            Console.WriteLine("anna uusi lämpötila: ");
            uusiArvo = Console.ReadLine();
            File.WriteAllText(tiedosto2, uusiArvo);
            Console.WriteLine("Uusi arvo talletettu!");
            Console.ReadLine();
        }
    }
}
