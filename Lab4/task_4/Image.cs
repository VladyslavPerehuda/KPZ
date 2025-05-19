public class Image
{
    private IImageLoader imageLoader;

    public Image(IImageLoader loader)
    {
        imageLoader = loader;
    }

    public void Load(string path)
    {
        imageLoader.LoadImage(path);
    }
}
