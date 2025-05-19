using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Button button = new Button();
        MouseOverListener mouseListener = new MouseOverListener();

        button.AddListener(mouseListener);
        button.Click();

        Console.ReadKey();
    }
}
