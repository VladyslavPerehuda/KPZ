public class Circle : Shape
{
    public Circle(IRenderer renderTool) : base(renderTool) { }

    public override void Draw()
    {
        RenderShape("Circle");
    }
}