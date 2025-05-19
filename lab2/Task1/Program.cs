using System;
using System.Collections.Generic;

public interface ISubscription
{
    decimal MonthlyFee { get; }
    int MinPeriodMonths { get; }
    List<string> Channels { get; }
    List<string> Features { get; }
    void ShowInfo();
}

public class DomesticSubscription : ISubscription
{
    public decimal MonthlyFee => 10.99m;
    public int MinPeriodMonths => 1;
    public List<string> Channels => new List<string> { "National TV", "News", "Kids" };
    public List<string> Features => new List<string> { "Basic Support" };

    public void ShowInfo()
    {
        Console.WriteLine("Domestic Subscription");
        Console.WriteLine($"Monthly Fee: {MonthlyFee}, Min Period: {MinPeriodMonths} months");
        Console.WriteLine($"Channels: {string.Join(", ", Channels)}");
        Console.WriteLine($"Features: {string.Join(", ", Features)}");
        Console.WriteLine();
    }
}

public class EducationalSubscription : ISubscription
{
    public decimal MonthlyFee => 5.99m;
    public int MinPeriodMonths => 3;
    public List<string> Channels => new List<string> { "Discovery", "Science", "History" };
    public List<string> Features => new List<string> { "Parental Control", "Study Resources" };

    public void ShowInfo()
    {
        Console.WriteLine("Educational Subscription");
        Console.WriteLine($"Monthly Fee: {MonthlyFee}, Min Period: {MinPeriodMonths} months");
        Console.WriteLine($"Channels: {string.Join(", ", Channels)}");
        Console.WriteLine($"Features: {string.Join(", ", Features)}");
        Console.WriteLine();
    }
}

public class PremiumSubscription : ISubscription
{
    public decimal MonthlyFee => 19.99m;
    public int MinPeriodMonths => 6;
    public List<string> Channels => new List<string> { "All Channels", "4K Movies", "Sports" };
    public List<string> Features => new List<string> { "24/7 Support", "Offline Access", "Multiple Screens" };

    public void ShowInfo()
    {
        Console.WriteLine("Premium Subscription");
        Console.WriteLine($"Monthly Fee: {MonthlyFee}, Min Period: {MinPeriodMonths} months");
        Console.WriteLine($"Channels: {string.Join(", ", Channels)}");
        Console.WriteLine($"Features: {string.Join(", ", Features)}");
        Console.WriteLine();
    }
}

public abstract class SubscriptionCreator
{
    public abstract ISubscription CreateSubscription();
}

public class WebSite : SubscriptionCreator
{
    public override ISubscription CreateSubscription()
    {
        Console.WriteLine("Created via WebSite");
        return new DomesticSubscription();
    }
}

public class MobileApp : SubscriptionCreator
{
    public override ISubscription CreateSubscription()
    {
        Console.WriteLine("Created via MobileApp");
        return new EducationalSubscription();
    }
}

public class ManagerCall : SubscriptionCreator
{
    public override ISubscription CreateSubscription()
    {
        Console.WriteLine("Created via Manager Call");
        return new PremiumSubscription();
    }
}

class Program
{
    static void Main(string[] args)
    {
        SubscriptionCreator creator1 = new WebSite();
        ISubscription sub1 = creator1.CreateSubscription();
        sub1.ShowInfo();

        SubscriptionCreator creator2 = new MobileApp();
        ISubscription sub2 = creator2.CreateSubscription();
        sub2.ShowInfo();

        SubscriptionCreator creator3 = new ManagerCall();
        ISubscription sub3 = creator3.CreateSubscription();
        sub3.ShowInfo();
        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}