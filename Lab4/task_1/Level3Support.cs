using System;

public class Level3Support : SupportHandler
{
    public override void HandleRequest(int level)
    {
        if (level == 3)
        {
            Console.WriteLine("Підтримка рівня 3: Допомога на високому рівні.");
        }
        else if (nextHandler != null)
        {
            nextHandler.HandleRequest(level);
        }
    }
}
