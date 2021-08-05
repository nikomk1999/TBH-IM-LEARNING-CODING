using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._06._2021_thing_for_learning
{
    class kirjailija
    {
        public string nimi { get; set; }
        public List<Kirja> kirjoja { get; set; }

        public kirjailija(string kirjailijanNimi)
        {
            nimi = kirjailijanNimi;
            kirjoja = new List<Kirja>();
        }

        public void lisaaKirja(Kirja kirja)
        {
            kirjoja.Add(kirja);
        }
    }
}
