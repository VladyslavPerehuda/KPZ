using System;

public class UrlImageLoader : IImageLoader
{
    public void LoadImage(string imagePath)
    {
        Console.WriteLine($"Завантаження з мережі: {imagePath}");
    }
}
