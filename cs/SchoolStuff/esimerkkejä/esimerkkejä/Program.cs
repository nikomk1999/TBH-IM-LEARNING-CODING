using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace esimerkkejä
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] nuymerotaulukkoTyh = new int[5];
            int[] numerotaulukko = new int[5] { 1, 3, 5, 7, 9 };

            numerotaulukko[0] = 200;


            //taulukon suurennus / kopiointi uuteen
            int[] numerotaulukko1 = new int[10];

            numerotaulukko.CopyTo(numerotaulukko1, 0);



            Console.WriteLine(numerotaulukko[0]);
            //[0, 0, 0, 0, 0]
            //0 1 2 3 4

            for (int i = 0; i < numerotaulukko.Length; i++)
            {
                Console.WriteLine(numerotaulukko[i]);
            }

            Console.ReadLine(); */








            int[,] kaksiulotteinene = new int[5, 5];
            int arvaus = 0;
            //[0, 0, 0, 0, 0]
            //[0, 0, 0, 0, 0]
            //[0, 0, 0, 0, 0]
            //[0, 0, 0, 0, 0]
            //[0, 0, 0, 0, 0]
            kaksiulotteinene[2, 2] = 5;
            //[0, 0, 0, 0, 0]
            //[0, 0, 0, 0, 0]
            //[0, 0, 200, 0, 0]
            //[0, 0, 0, 0, 0]
            //[0, 0, 0, 0, 0]

            //locations = 
            //[0, 1, 2, 3, 4] ->
            //[1]\/
            //[2]\/
            //[3]\/
            //[4]\/











            Console.WriteLine("kaksi ullotteiset tässä alla");
            Console.WriteLine("anna luku:");
            bool loytyi = false;
            arvaus = int.Parse(Console.ReadLine());
            if (loytyi == false)
            {
                for (int i = 0; i < 5; i++)
                {

                    for (int j = 0; j < 5; j++)
                    {
                        if (kaksiulotteinene[i, j] == arvaus)
                        {
                            Console.WriteLine("luku löytyi paikasta " + i + "," + j);
                            loytyi = true;
                            break;
                            Console.Clear();
                        }
                        {
                            kaksiulotteinene[i, j] = 1;
                            printingtm(kaksiulotteinene);
                            Thread.Sleep(500);
                            Console.Clear();
                        }
                    }
                }
            }
            int[,,] kolmiuloitteinen = new int[5, 5, 5];

            Console.ReadLine();









            /*
                        List<int> numerolista = new List<int>() { 1, 2, 3 };
                        List<string> merkkilista = new List<string>();


                        numerolista.Add(500);
                        numerolista.Remove(500);

                        merkkilista.Add("merkkijono");
                        merkkilista.Add("merkkijono");
                        merkkilista.Remove("merkkijono");

                        int pituus = merkkilista.Count();
                        Console.WriteLine(pituus);

                        Console.ReadLine();

                        foreach (int numero in numerolista)
                        {
                            Console.WriteLine(numero);
                        }

                        Console.ReadLine();

                        string[] lines = // :)
                                    {
                            "first line", "second line", "third line"
                        };

                        File.WriteAllLines("WriteLines.txt", lines); // writes text into file
                        string[] Texts = System.IO.File.ReadAllLines("WriteLines.txt"); // reading all lines in text file :)

                        foreach (String a in Texts) // reading all lines in text file :)
                        {
                            Console.WriteLine(a);
                        }

                        Console.WriteLine("test?");
                        Console.ReadLine();


                        text();

                        Console.ReadLine();


                        List<char> merkkeja = new List<char>();

                        while (true)
                        {
                            char merkki = Console.ReadKey().KeyChar;
                            if (merkki == 'q')
                            {
                                break;
                            }
                            merkkeja.Add(merkki);

                        }

                        foreach (char a in merkkeja)
                        {
                            Console.WriteLine(a);
                        }
                    }

                    static void text()
                    {
                        string[] lines =
                                    {
                            "first line", "second line", "third line"
                        };

                        File.WriteAllLines("WriteLines.txt", lines);
                        Console.WriteLine("test?");
                        Console.ReadLine(); */










        }

        private static void printingtm(int[,] kaksiulotteinene)
        {
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 5; j++)
                {
                    Console.Write(kaksiulotteinene[i, j]);
                }
            }
        }
    }
}

