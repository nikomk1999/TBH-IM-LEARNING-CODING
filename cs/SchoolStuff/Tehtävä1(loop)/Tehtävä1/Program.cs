using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hei käyttäjä annatko minulle jonkun numeron...");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine("toistetaan " + (i+1));
                if (numero > 100)
                {
                    Console.WriteLine("laittaisitko pienemmän numeron kuin: " + numero + '?');
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
