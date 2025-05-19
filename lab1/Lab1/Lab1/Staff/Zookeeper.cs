using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Staff
{
    public class Zookeeper : IStaff
    {
        public string Name { get; }
        public string Position { get; } = "Zookeeper";

        public Zookeeper(string name)
        {
            Name = name;
        }

        public void Work()
        {
            Console.WriteLine($"{Name} Zookeeper feeding and caring for the animals.");
        }
    }
}
