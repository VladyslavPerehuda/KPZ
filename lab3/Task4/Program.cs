using System;
using System.IO;
using System.Reflection.PortableExecutable;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using Task4;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        
        string filePath = "data.txt";
        File.WriteAllLines(filePath, new[] {
            "Вітаємо у системі!",
            "Це тестовий документ.",
            "Останній рядок."
        });

       
        ISmartTextReader textReader = new SmartTextReader();
        Console.WriteLine("\n--- Пряме читання файлу ---");
        var content = textReader.ReadFile(filePath);
        foreach (var line in content)
            Console.WriteLine(new string(line));

        
        Console.WriteLine("\n--- Читання з логуванням ---");
        ISmartTextReader reader = new SmartTextReader();
        ISmartTextReader logReader = new SmartTextChecker(reader);
        logReader.ReadFile(filePath);


        Console.WriteLine("\n--- Читання з обмеженням (*.private*) ---");
        ISmartTextReader secureReader = new SmartTextReaderLocker(textReader, ".*private.*");
        secureReader.ReadFile("my_private_data.txt");
        secureReader.ReadFile(filePath);

        Console.WriteLine("\nНатисніть Enter для завершення...");
        Console.ReadLine();
    }
}