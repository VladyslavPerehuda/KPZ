using Lab1.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Enclosures
{
    public class Savannah : IEnclosure
    {
        public string Type { get; } = "Savannah";
        private List<IAnimal> animals = new List<IAnimal>();

        public void AddAnimal(IAnimal animal)
        {
            animals.Add(animal);
            Console.WriteLine($"{animal.Name} added to Savannah.");
        }

        public void RemoveAnimal(IAnimal animal)
        {
            animals.Remove(animal);
            Console.WriteLine($"{animal.Name} removed from Savanna.");
        }
    }
}
