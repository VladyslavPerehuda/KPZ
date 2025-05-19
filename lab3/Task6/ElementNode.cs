public class ElementNode : HtmlNode
{
    public ElementIntrinsicState IntrinsicState { get; }
    public List<HtmlNode> Children { get; } = new List<HtmlNode>();

    public ElementNode(ElementIntrinsicState intrinsicState)
    {
        IntrinsicState = intrinsicState;
    }

    public void AddChild(HtmlNode child)
    {
        Children.Add(child);
    }

    public override string OuterHTML
    {
        get
        {
            string inner = string.Join("", Children.ConvertAll(c => c.OuterHTML));
            string classes = string.Join(" ", IntrinsicState.CssClasses);
            string closeTag = IntrinsicState.Closing == ClosingType.Pair ? $"</{IntrinsicState.TagName}>" : "";
            return $"<{IntrinsicState.TagName} class=\"{classes}\">{inner}{closeTag}";
        }
    }

    public override string InnerHTML
    {
        get
        {
            return string.Join("", Children.ConvertAll(c => c.OuterHTML));
        }
    }
}