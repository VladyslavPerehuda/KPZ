using System;

public class VectorRenderer : IRenderer
{
    public void Render(string shapeName)
    {
        Console.WriteLine($"Rendering {shapeName} as vector graphics.");
    }
}