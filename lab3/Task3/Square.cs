public class Square : Shape
{
    public Square(IRenderer renderTool) : base(renderTool) { }

    public override void Draw()
    {
        RenderShape("Square");
    }
}