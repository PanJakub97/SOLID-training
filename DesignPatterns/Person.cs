using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class Person
    {
        public string Name;

        public Person(string Name, int Age)
        {
            this.Name = Name;
        }
        public void SayHi()
        {
            Console.WriteLine("Hello, my name is " + this.Name);
        }
    }
}
