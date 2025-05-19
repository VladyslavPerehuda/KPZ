using Lab1.Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Animals
{
    public class Parrot : IAnimal
    {
        public string Name { get; }
        public string Species { get; } = "Parrot";

        public Parrot(string name)
        {
            Name = name;
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} the Parrot squawks: Squawk!");
        }

        public void Eat(IFood food)
        {
            Console.WriteLine($"{Name} the Parrot eats {food.Type}.");
        }
    }
}
