using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab5_10._04_.Pet
{
    class Parrot : Pet
    {
        private string Color;

        public Parrot(string name, double age, string color) : base(name, age)
        {
            this.Color = color;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Squawk!");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Color: {Color}");
        }
    }
}
