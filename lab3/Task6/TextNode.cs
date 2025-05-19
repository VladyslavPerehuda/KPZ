public class TextNode : HtmlNode
{
    public string Text { get; }

    public TextNode(string text)
    {
        Text = text;
    }

    public override string OuterHTML => Text;
    public override string InnerHTML => Text;
}