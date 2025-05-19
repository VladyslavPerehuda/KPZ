public class Triangle : Shape
{
    public Triangle(IRenderer renderTool) : base(renderTool) { }

    public override void Draw()
    {
        RenderShape("Triangle");
    }
}