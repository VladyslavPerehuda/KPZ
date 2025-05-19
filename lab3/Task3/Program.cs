using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

       
        IRenderer vectorTool = new VectorRenderer();
        IRenderer rasterTool = new RasterRenderer();

        
        Shape roundShape = new Circle(rasterTool);
        Shape boxShape = new Square(vectorTool);
        Shape triShape = new Triangle(vectorTool);

        triShape.Draw();
        boxShape.Draw();
        roundShape.Draw();

        Console.WriteLine("\nНатисніть Enter для завершення...");
        Console.ReadLine();
    }
}