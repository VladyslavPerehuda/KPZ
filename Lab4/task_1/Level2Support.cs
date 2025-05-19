using System;

public class Level2Support : SupportHandler
{
    public override void HandleRequest(int level)
    {
        if (level == 2)
        {
            Console.WriteLine("Підтримка рівня 2: Допомога на середньому рівні.");
        }
        else if (nextHandler != null)
        {
            nextHandler.HandleRequest(level);
        }
    }
}
