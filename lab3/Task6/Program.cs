using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static async Task Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        var elementFactory = new ElementFactory();
        string url = "https://www.gutenberg.org/cache/epub/1513/pg1513.txt";
        string text = await DownloadTextAsync(url);
        string[] lines = text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

        var htmlTree = BuildHtmlTree(lines, elementFactory);

        Console.WriteLine("Згенерований HTML:");
        Console.WriteLine(htmlTree.OuterHTML);

        Console.WriteLine($"\nКількість унікальних тегів у фабриці: {elementFactory.CachedCount}");
        Console.WriteLine($"\nКількість елементів у дереві: {htmlTree.Children.Count}");
        Console.WriteLine("\nНатисніть Enter для завершення...");
        Console.ReadLine();
    }

    private static async Task<string> DownloadTextAsync(string url)
    {
        using var client = new HttpClient();
        return await client.GetStringAsync(url);
    }

    private static ElementNode BuildHtmlTree(string[] lines, ElementFactory factory)
    {
        var bodyState = factory.GetIntrinsicState("div", DisplayType.Block, ClosingType.Pair);
        var body = new ElementNode(bodyState);
        bool isFirstLine = true;
        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
                continue;
            string tagName = DetermineTagType(line, isFirstLine);
            isFirstLine = false;
            var state = factory.GetIntrinsicState(tagName, DisplayType.Block, ClosingType.Pair);
            var element = new ElementNode(state);
            element.AddChild(new TextNode(line.Trim()));
            body.AddChild(element);
        }
        return body;
    }

    private static string DetermineTagType(string line, bool isFirstLine)
    {
        if (isFirstLine)
            return "h1";
        if (line.Length < 20)
            return "h2";
        if (line.StartsWith(" "))
            return "blockquote";
        return "p";
    }
}