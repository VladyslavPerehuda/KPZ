using Lab1.Animals;
using Lab1.Enclosures;
using Lab1.Food;
using Lab1.Staff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Management
{
    public class ZooInventory
    {
        private List<IAnimal> animals = new List<IAnimal>();
        private List<IEnclosure> enclosures = new List<IEnclosure>();
        private List<IStaff> staff = new List<IStaff>();
        private List<IFood> foods = new List<IFood>();

        public void AddAnimal(IAnimal animal)
        {
            animals.Add(animal);
        }

        public void AddEnclosure(IEnclosure enclosure)
        {
            enclosures.Add(enclosure);
        }

        public void AddStaff(IStaff employee)
        {
            staff.Add(employee);
        }

        public void AddFood(IFood food)
        {
            foods.Add(food);
        }

        public void PrintReport()
        {
            Console.WriteLine($"Total Animals: {animals.Count}");
            Console.WriteLine($"Total Enclosures: {enclosures.Count}");
            Console.WriteLine($"Total Staff: {staff.Count}");
            Console.WriteLine($"Total Food Types: {foods.Count}");
        }
    }
}
