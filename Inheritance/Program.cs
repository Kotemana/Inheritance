using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var zoo = new List<Animal>();
            zoo.Add(new Dog() { Name = "Barbos" });
            zoo.Add(new Cat() { Name = "Ryzhik", HasBalls = true });
            zoo.Add(new Cat() { Name = "Dexter", HasBalls = false });
            zoo.Add(new Animal() { Name = "Cheburashka" });
            zoo.Add(new Fish() { Name = "Yellow striped", IsEadible = true });
            zoo.Add(new Fish() { Name = "Fugu", IsEadible = false });

            foreach (var animal in zoo)
            {
                animal.SaySomething();
                
                if(animal is Cat cat)
                {
                    Console.WriteLine($"Cat is CAT: {cat.HasBalls}");
                }
                if(animal is Fish fishyFishy)
                {
                    if (!fishyFishy.IsEadible)
                    {
                        Console.WriteLine("You Died!");
                    }
                }
            }
        }
    }
}
