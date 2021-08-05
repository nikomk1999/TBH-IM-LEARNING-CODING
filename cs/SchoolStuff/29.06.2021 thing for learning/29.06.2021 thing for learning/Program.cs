using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._06._2021_thing_for_learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person(5, "anu", "");
            Person p2 = new Person(1, "bikash", "");
            Person p3 = new Person(1, "jan", "");

            List<Person> pList = new List<Person>();

            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);

            Console.WriteLine(p1.sayHi());

            Console.ReadLine();


            List<kirjailija> lista = new List<kirjailija>();
            kirjailija kirjailija = new kirjailija("eino leino");

            Kirja kirja = new Kirja("Maaliskuun laulaja");


            kirjailija.lisaaKirja(kirja);

            Console.WriteLine(kirjailija.kirjoja[0].nimi);

            Console.ReadLine();
        }
    }
}
