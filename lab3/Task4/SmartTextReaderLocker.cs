using System;
using System.Text.RegularExpressions;
using System;
using System.IO;
using Task4;

public class SmartTextReaderLocker : ISmartTextReader
{
    private ISmartTextReader _fileReader; 
    private Regex _restrictPattern; 

    public SmartTextReaderLocker(ISmartTextReader fileReader, string denyRegex)
    {
        _fileReader = fileReader;
        _restrictPattern = new Regex(denyRegex, RegexOptions.IgnoreCase);
    }

    public char[][] ReadFile(string path)
    {
        if (_restrictPattern.IsMatch(path))
        {
            Console.WriteLine("Доступ заборонено!");
            return new char[0][];
        }

        return _fileReader.ReadFile(path);
    }
}