using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab5_10._04_.Pet
{
    class Bird : Pet
    {
        private string Species;

        public Bird(string name, double age, string species) : base(name, age)
        {
            Species = species;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Caw caw!");
        }

        public override void PrintInfo() 
        {
            base.PrintInfo();
            Console.WriteLine($"Species: {Species}");
        }
    }
}
