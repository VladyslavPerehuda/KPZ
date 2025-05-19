using System;
using Task4;

public class SmartTextChecker : ISmartTextReader
{
    private ISmartTextReader _fileReader; 

    public SmartTextChecker(ISmartTextReader fileReader)
    {
        _fileReader = fileReader;
    }

    public char[][] ReadFile(string path)
    {
        Console.WriteLine($"Спроба відкрити файл: {path}");

        char[][] result = _fileReader.ReadFile(path);

        Console.WriteLine("Файл успішно прочитано.");
        Console.WriteLine($"Кількість рядків: {result.Length}");

        int charCount = 0;
        foreach (var line in result)
            charCount += line.Length;

        Console.WriteLine($"Кількість символів: {charCount}");

        return result;
    }
}