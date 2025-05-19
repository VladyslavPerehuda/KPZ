using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        try
        {
            
            var table = new LightElementNode("table", DisplayType.Block, ClosingType.Pair);
            table.AddStyle("data-table");

            var row = new LightElementNode("tr", DisplayType.Block, ClosingType.Pair);
            var cell1 = new LightElementNode("td", DisplayType.Block, ClosingType.Pair);
            cell1.AppendNode(new LightTextNode("Клітинка 1")); 
            var cell2 = new LightElementNode("td", DisplayType.Block, ClosingType.Pair);
            cell2.AppendNode(new LightTextNode("Клітинка 2")); 

            row.AppendNode(cell1);
            row.AppendNode(cell2);
            table.AppendNode(row);

            
            Console.WriteLine("HTML representation:");
            Console.WriteLine(table.OuterHTML);

            
            Console.WriteLine($"\nКількість дочірніх елементів у таблиці: {table.ChildCount}");

            
            Console.WriteLine("\nHuman-readable structure:");
            table.DisplayStructure();

            Console.WriteLine("\nНатисніть Enter для завершення...");
            Console.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Виникла помилка: {ex.Message}");
            Console.WriteLine("\nНатисніть Enter для завершення...");
            Console.ReadLine();
        }
    }
}