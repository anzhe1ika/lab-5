using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_10._04_.Pet
{
    abstract class Pet
    {
        protected string Name;
        protected double Age;

        public Pet(string name, double age)
        {
            Name = name;
            Age = age;
        }

        public abstract void MakeSound();

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
