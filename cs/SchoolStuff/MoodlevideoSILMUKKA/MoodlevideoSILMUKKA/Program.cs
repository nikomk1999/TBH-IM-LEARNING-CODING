using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodlevideoSILMUKKA
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadLine();
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine("ollaan");
                Console.WriteLine(j.ToString());
                j++;
            }
            Console.ReadLine();
            int k = 10;
            do
            {
                Console.WriteLine("ollaan");
                Console.WriteLine(k.ToString());
                k++;
            } while (k<0);
            Console.ReadLine();
        }
    }
}
