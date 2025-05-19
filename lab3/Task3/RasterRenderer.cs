using System;

public class RasterRenderer : IRenderer
{
    public void Render(string shapeName)
    {
        Console.WriteLine($"Rendering {shapeName} as raster graphics.");
    }
}