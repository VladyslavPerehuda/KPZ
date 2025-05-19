namespace Task4
{
    using System.IO;

    public class SmartTextReader : ISmartTextReader
    {
        public char[][] ReadFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            char[][] result = new char[lines.Length][];

            for (int i = 0; i < lines.Length; i++)
            {
                result[i] = lines[i].ToCharArray();
            }

            return result;
        }
    }
}