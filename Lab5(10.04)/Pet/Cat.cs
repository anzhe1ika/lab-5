using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab5_10._04_.Pet
{
    class Cat : Pet
    {
        private bool IsIndoor;

        public Cat(string name, double age, bool isIndoor) : base(name, age)
        {
            IsIndoor = isIndoor;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Meow!");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Is Indoor: {IsIndoor}");
        }
    }
}
