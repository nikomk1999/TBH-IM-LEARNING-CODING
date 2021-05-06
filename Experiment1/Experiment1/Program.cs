using System;

namespace Experiment1
{
    class Program
    {
        static void Main(string[] args)
        {   
            byte number = 1;
            byte number2 = 128;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'B';
            string FirstName = "Niko";
            bool IsWorking = false;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(FirstName);
            Console.WriteLine(IsWorking);
            number = (byte) (number + 255);
            Console.WriteLine(number + "yo cool if its less than like 100 it overflowed");
            checked
            {
                number = (byte)(number + 254);
                Console.WriteLine(number + "this should be like ~254");
                number = (byte)(number + 250);
                Console.WriteLine(number + "this should not overflow");
            }
            System.Threading.Thread.Sleep(5000);
        }
    }
}
