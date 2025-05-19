using System;
using System.Collections.Generic;

public class Virus : ICloneable
{
    public string Name { get; set; }
    public string Type { get; set; }
    public List<Virus> Children { get; set; } = new List<Virus>();

    public Virus(string name, string type)
    {
        Name = name;
        Type = type;
    }

    public object Clone()
    {
        Virus clone = new Virus(Name, Type);
        foreach (var child in Children)
        {
            clone.Children.Add((Virus)child.Clone());
        }
        return clone;
    }

    public void Print()
    {
        Console.WriteLine("Virus: " + Name + ", Type: " + Type);
        foreach (var child in Children)
        {
            child.Print();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Task 4");
        Virus parent = new Virus("Parent", "TypeA");
        Virus child1 = new Virus("Child1", "TypeB");
        Virus child2 = new Virus("Child2", "TypeC");
        parent.Children.Add(child1);
        parent.Children.Add(child2);

        Virus clone = (Virus)parent.Clone();

        Console.WriteLine("Original:");
        parent.Print();
        Console.WriteLine("Clone:");
        clone.Print();

        Console.WriteLine("Press Enter to continue");
        Console.ReadLine();
    }
}