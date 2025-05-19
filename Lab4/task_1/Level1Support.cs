using System;

public class Level1Support : SupportHandler
{
    public override void HandleRequest(int level)
    {
        if (level == 1)
        {
            Console.WriteLine("Підтримка рівня 1: Допомога на базовому рівні.");
        }
        else if (nextHandler != null)
        {
            nextHandler.HandleRequest(level);
        }
    }
}
