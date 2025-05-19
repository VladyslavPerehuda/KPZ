public abstract class Shape
{
    protected IRenderer _renderTool; 

    public Shape(IRenderer renderTool)
    {
        _renderTool = renderTool;
    }

   
    protected void RenderShape(string name)
    {
        _renderTool.Render(name);
    }

    public abstract void Draw();
}