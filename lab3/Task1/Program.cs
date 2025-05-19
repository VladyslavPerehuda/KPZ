using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        
        Logger consoleOutput = new Logger();
        consoleOutput.Log("Інформаційне повідомлення");
        consoleOutput.Warn("Попередження системи");
        consoleOutput.Error("Критична помилка");

        
        FileWriter fileHandler = new FileWriter("system_log.txt");
        Logger fileOutput = new FileLoggerAdapter(fileHandler);
        fileOutput.Log("Запис інформації у файл");
        fileOutput.Warn("Попередження у файлі");
        fileOutput.Error("Помилка у файлі");

        Console.WriteLine("Операція завершена. Перевірте system_log.txt.");
        Console.WriteLine("Натисніть Enter для виходу...");
        Console.ReadLine();
    }
}