using System;

public class MouseOverListener : IEventListener
{
    public void HandleEvent(string eventName)
    {
        if (eventName == "click")
        {
            Console.WriteLine("Кнопка була натиснута!");
        }
        else
        {
            Console.WriteLine("Інший івент: " + eventName);
        }
    }
}
