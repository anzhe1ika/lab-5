using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab5_10._04_.Pet
{
    class Dog : Pet
    {
        private string Breed;

        public Dog(string name, double age, string breed) : base(name, age)
        {
            this.Breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Woof!");
        }

        public override void PrintInfo() // Overriding PrintInfo method to include breed
        {
            base.PrintInfo();
            Console.WriteLine($"Breed: {Breed}");
        }
    }
}
