using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSample
{
    class Sample04
    {
        public  Person p = new Person();
        public Sample04(string a, int b) 
        {
            p.Name = a;
            p.Age = b;

            Console.WriteLine($"Hello {p.Name} !! Your Age is {p.Age}, Right?");
        }

        public Sample04(int g) : this("Corn", g)
        {

        }

        public Sample04() : this("Edward", 33)
        {

        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
