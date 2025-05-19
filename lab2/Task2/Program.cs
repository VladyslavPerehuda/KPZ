using System;

public interface ILaptop
{
    void ShowInfo();
}

public interface INetbook
{
    void ShowInfo();
}

public interface IEBook
{
    void ShowInfo();
}

public interface ISmartphone
{
    void ShowInfo();
}

public class IProneLaptop : ILaptop
{
    public void ShowInfo() => Console.WriteLine("IProne Laptop: High-performance laptop.");
}

public class IProneNetbook : INetbook
{
    public void ShowInfo() => Console.WriteLine("IProne Netbook: Compact and efficient.");
}

public class IProneEBook : IEBook
{
    public void ShowInfo() => Console.WriteLine("IProne EBook: Advanced e-reader.");
}

public class IProneSmartphone : ISmartphone
{
    public void ShowInfo() => Console.WriteLine("IProne Smartphone: Premium smartphone.");
}

public class KiaomiLaptop : ILaptop
{
    public void ShowInfo() => Console.WriteLine("Kiaomi Laptop: Affordable and reliable.");
}

public class KiaomiNetbook : INetbook
{
    public void ShowInfo() => Console.WriteLine("Kiaomi Netbook: Budget-friendly netbook.");
}

public class KiaomiEBook : IEBook
{
    public void ShowInfo() => Console.WriteLine("Kiaomi EBook: Basic e-reader.");
}

public class KiaomiSmartphone : ISmartphone
{
    public void ShowInfo() => Console.WriteLine("Kiaomi Smartphone: Feature-rich smartphone.");
}

public class BalaxyLaptop : ILaptop
{
    public void ShowInfo() => Console.WriteLine("Balaxy Laptop: Innovative design.");
}

public class BalaxyNetbook : INetbook
{
    public void ShowInfo() => Console.WriteLine("Balaxy Netbook: Ultra-portable.");
}

public class BalaxyEBook : IEBook
{
    public void ShowInfo() => Console.WriteLine("Balaxy EBook: High-resolution display.");
}

public class BalaxySmartphone : ISmartphone
{
    public void ShowInfo() => Console.WriteLine("Balaxy Smartphone: Cutting-edge technology.");
}

public interface IDeviceFactory
{
    ILaptop CreateLaptop();
    INetbook CreateNetbook();
    IEBook CreateEBook();
    ISmartphone CreateSmartphone();
}

public class IProneFactory : IDeviceFactory
{
    public ILaptop CreateLaptop() => new IProneLaptop();
    public INetbook CreateNetbook() => new IProneNetbook();
    public IEBook CreateEBook() => new IProneEBook();
    public ISmartphone CreateSmartphone() => new IProneSmartphone();
}

public class KiaomiFactory : IDeviceFactory
{
    public ILaptop CreateLaptop() => new KiaomiLaptop();
    public INetbook CreateNetbook() => new KiaomiNetbook();
    public IEBook CreateEBook() => new KiaomiEBook();
    public ISmartphone CreateSmartphone() => new KiaomiSmartphone();
}

public class BalaxyFactory : IDeviceFactory
{
    public ILaptop CreateLaptop() => new BalaxyLaptop();
    public INetbook CreateNetbook() => new BalaxyNetbook();
    public IEBook CreateEBook() => new BalaxyEBook();
    public ISmartphone CreateSmartphone() => new BalaxySmartphone();
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Task 2: Abstract Factory");
        IDeviceFactory factory = new IProneFactory();
        ILaptop laptop = factory.CreateLaptop();
        INetbook netbook = factory.CreateNetbook();
        IEBook ebook = factory.CreateEBook();
        ISmartphone smartphone = factory.CreateSmartphone();

        laptop.ShowInfo();
        netbook.ShowInfo();
        ebook.ShowInfo();
        smartphone.ShowInfo();

        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}