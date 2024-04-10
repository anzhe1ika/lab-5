using Lab5_10._04_.Pet;
using System;

class Program
{
    static void Main(string[] args)
    {
        Pet dog = new Dog("Jack", 3, "Labrador");
        Pet cat = new Cat("Murchik", 1, true);
        Pet parrot = new Parrot("Richi", 2, "White with yellow and gray");
        Pet bird = new Bird("Vasily", 1.5, "Crow");

        Console.WriteLine("The dog: ");
        dog.PrintInfo();
        dog.MakeSound();
        Console.WriteLine();

        Console.WriteLine("The cat: ");
        cat.PrintInfo();
        cat.MakeSound();
        Console.WriteLine();

        Console.WriteLine("The parrot: ");
        parrot.PrintInfo();
        parrot.MakeSound();
        Console.WriteLine();

        Console.WriteLine("The Bird: ");
        bird.PrintInfo();
        bird.MakeSound();
    }
}
