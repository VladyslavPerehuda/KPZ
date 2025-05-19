using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        SupportHandler level1 = new Level1Support();
        SupportHandler level2 = new Level2Support();
        SupportHandler level3 = new Level3Support();
        SupportHandler level4 = new Level4Support();

        level1.SetNextHandler(level2);
        level2.SetNextHandler(level3);
        level3.SetNextHandler(level4);

  
        Console.WriteLine("Виберіть рівень підтримки (1-4): ");
        int level = int.Parse(Console.ReadLine());

        level1.HandleRequest(level);

        Console.ReadKey();
    }
}
