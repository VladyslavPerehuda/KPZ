public interface IImageLoader
{
    void LoadImage(string href);
}

public class FileImageLoader : IImageLoader
{
    public void LoadImage(string href)
    {
        Console.WriteLine($"Loading image from file system: {href}");
    }
}

public class NetworkImageLoader : IImageLoader
{
    public void LoadImage(string href)
    {
        Console.WriteLine($"Loading image from network: {href}");
    }
}