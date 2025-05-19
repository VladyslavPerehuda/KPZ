using System;
using System.Collections.Generic;

public class TextEditor
{
    private TextDocument document = new TextDocument();
    private Stack<Memento> history = new Stack<Memento>();

    public void SetText(string text)
    {
        history.Push(new Memento(document.Content));
        document.Content = text;
    }

    public void Undo()
    {
        if (history.Count > 0)
        {
            document.Content = history.Pop().State;
        }
    }

    public void ShowText()
    {
        Console.WriteLine("Текст документу: " + document.Content);
    }
}
