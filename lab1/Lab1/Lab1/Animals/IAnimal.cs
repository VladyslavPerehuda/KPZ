using Lab1.Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Animals
{
    public interface IAnimal
    {
        string Name { get; }
        string Species { get; }
        void MakeSound();
        void Eat(IFood food);
    }
}
