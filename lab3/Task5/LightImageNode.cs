using System;

public class LightImageNode : LightElementNode
{
    private string _href;
    private IImageLoader _loader;

    public LightImageNode(string href) : base("img", DisplayType.Inline, ClosingType.SelfClosing)
    {
        _href = href;
        Uri uri;
        if (Uri.TryCreate(href, UriKind.Absolute, out uri) && (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps))
        {
            _loader = new NetworkImageLoader();
        }
        else
        {
            _loader = new FileImageLoader();
        }
    }

    public void Load()
    {
        _loader.LoadImage(_href);
    }

    public override string OuterHTML
    {
        get
        {
            string styleAttr = Styles.Count > 0 ? $" class=\"{string.Join(" ", Styles)}\"" : "";
            return $"<{TagName} src=\"{_href}\"{styleAttr} />";
        }
    }
}