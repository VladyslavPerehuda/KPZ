using Lab1.Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Animals
{
    public class Lion : IAnimal
    {
        public string Name { get; }
        public string Species { get; } = "Lion";

        public Lion(string name)
        {
            Name = name;
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} the Lion roar");
        }

        public void Eat(IFood food)
        {
            Console.WriteLine($"{Name} the Lion eats {food.Type}.");
        }
    }
}
