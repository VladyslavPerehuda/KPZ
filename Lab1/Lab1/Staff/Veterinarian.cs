using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Staff
{
    public class Veterinarian : IStaff
    {
        public string Name { get; }
        public string Position { get; } = "Veterinarian";

        public Veterinarian(string name)
        {
            Name = name;
        }

        public void Work()
        {
            Console.WriteLine($"{Name} Veterinarian is treating sick animals.");
        }
    }
}
