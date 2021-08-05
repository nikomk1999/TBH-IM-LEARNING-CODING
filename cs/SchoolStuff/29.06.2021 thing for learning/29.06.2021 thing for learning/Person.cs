using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._06._2021_thing_for_learning
{
    class Person
    {
        public int age { get; set; }
        public string name { get; set; }
        public string suosikkivari { get; set; }

        public Person(int personAge, string personName, string personSuosikkivari)
        {
            age = personAge;
            name = personName;
            suosikkivari = personSuosikkivari;
        }

        public string sayHi()
        {
            return "moi mina olen " + name + " olen " + age + " vuotias, suosikkivärini on " + suosikkivari;
        }


    }
}
