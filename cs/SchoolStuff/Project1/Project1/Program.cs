using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int numbaw = 20;
            Console.WriteLine(10/numbaw); 
            */


            Console.WriteLine("What is your firts name(s)?");
            string Fname = Console.ReadLine();

            char symbole = '!';

            Console.WriteLine("Surname?");
            string Sname = string.Format(Console.ReadLine());
            Console.WriteLine("What is your favorite number?");
            int number1 = int.Parse(Console.ReadLine());

            if (number1 < 10)
            {
                Console.WriteLine("hello " + Fname + ' ' + Sname + symbole + ' ' + "thou number is smaller than 10 " + '"' + number1 + '"');
            }
            else
            {
                Console.WriteLine("hello " + Fname + ' ' + Sname + symbole + ' ' + "thou number is " + number1);
            }
            Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("toistetaan " + i);
                if (i - 3 == 0)
                {
                    Console.WriteLine(i + " i on nolla jos siitä vähennetään 3");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
