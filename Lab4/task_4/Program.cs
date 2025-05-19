using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        IImageLoader fileLoader = new FileImageLoader();
        IImageLoader urlLoader = new UrlImageLoader();

        Image fileImage = new Image(fileLoader);
        Image urlImage = new Image(urlLoader);

        fileImage.Load("image.jpg");
        urlImage.Load("http://example.com/image.jpg");

        Console.ReadKey();
    }
}
