
public class ElementIntrinsicState
{
    public string TagName { get; }
    public DisplayType Display { get; }
    public ClosingType Closing { get; }
    public List<string> CssClasses { get; } = new List<string>();

    public ElementIntrinsicState(string tagName, DisplayType display, ClosingType closing)
    {
        TagName = tagName;
        Display = display;
        Closing = closing;
    }
}