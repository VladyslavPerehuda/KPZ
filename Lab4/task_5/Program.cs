using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        TextEditor editor = new TextEditor();

        editor.SetText("Привіт, світ!");
        editor.ShowText();

        editor.SetText("Це тест.");
        editor.ShowText();

        editor.Undo();
        editor.ShowText();

        Console.ReadKey();
    }
}
