using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvauspeli
{
    class Program
    {
        static void Main(string[] args)
        {
            int rNumber = new Random().Next(1, 101), arvaus; //asettaa rNumber muuttujalle "random" arvon 1-100 välillä
            List<int> arvaukset = new List<int>(); // tekee uuden listan testattujen numeroiden seuraamista varten
            do
            {
                Console.Write("Yritä arvata random luku (1-100): "); //...
                while (!int.TryParse(Console.ReadLine(), out arvaus)) Console.WriteLine("antamasi asia ei ollut numero... yritätkö uudelleen..."); //katsoo jos syetetty asia on numero. jos on jatkaa normaalisti, muulloin pyytää yrittämään uudelleen
                arvaukset.Add(arvaus); //lisää listaan arvatun numeron
                if (arvaus == rNumber) Console.WriteLine("Onnittelut arvasit oikein numero oli {0} \nsinä arvasit {1} kertaa\narvauksesi ovat numerot: {2}!", rNumber, arvaukset.Count, String.Join(", ", arvaukset)); //tulostaa random numerosi, kuinkamonta kertaa arvasit ja arvaamasi numerot. jos arvasit numeron oikein
                else if (arvaus > rNumber) Console.WriteLine("numero on pienempi kuin antamasi {0} numero. ", arvaus); // arvasit liian ylös
                else Console.WriteLine("numero on suurempi kuin antamasi {0} numero. ", arvaus); // arvasti liian alas yms
            } while (arvaus != rNumber); // loop loppuu koska arvasit oikein
            Console.WriteLine("\npaina entteriä poistuukseasi"); //...
            Console.ReadLine(); //koodi loppuu tähän
        }
    }
}
