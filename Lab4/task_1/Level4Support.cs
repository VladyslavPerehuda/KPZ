using System;

public class Level4Support : SupportHandler
{
    public override void HandleRequest(int level)
    {
        if (level == 4)
        {
            Console.WriteLine("Підтримка рівня 4: Експертна допомога.");
        }
        else
        {
            Console.WriteLine("Немає відповідного рівня підтримки.");
        }
    }
}