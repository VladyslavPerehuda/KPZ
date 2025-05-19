using System;

public class FileImageLoader : IImageLoader
{
    public void LoadImage(string imagePath)
    {
        Console.WriteLine($"Завантаження з файлової системи: {imagePath}");
    }
}
