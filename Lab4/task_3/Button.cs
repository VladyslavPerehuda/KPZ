using System;
using System.Collections.Generic;

public class Button
{
    private List<IEventListener> listeners = new List<IEventListener>();

    public void AddListener(IEventListener listener)
    {
        listeners.Add(listener);
    }

    public void Click()
    {
        Console.WriteLine("Кнопка натиснута!");
        foreach (var listener in listeners)
        {
            listener.HandleEvent("click");
        }
    }
}
