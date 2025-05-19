using Lab1.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Enclosures
{
    public interface IEnclosure
    {
        string Type { get; }
        void AddAnimal(IAnimal animal);
        void RemoveAnimal(IAnimal animal);
    }
}