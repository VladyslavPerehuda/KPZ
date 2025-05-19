using System;
using System.Collections.Generic;
using System.Text;


public class LightElementNode : LightNode
{
    public string TagName { get; }
    public DisplayType Display { get; }
    public ClosingType Closing { get; }
    public List<string> Styles { get; }
    public List<LightNode> SubNodes { get; }

   
    public int ChildCount => SubNodes.Count;

  
    public LightElementNode(string tagName, DisplayType display, ClosingType closing)
    {
        TagName = tagName ?? throw new ArgumentNullException(nameof(tagName));
        Display = display;
        Closing = closing;
        Styles = new List<string>();
        SubNodes = new List<LightNode>();
    }

    
    public void AddStyle(string style)
    {
        if (!string.IsNullOrEmpty(style))
        {
            Styles.Add(style);
        }
    }

   
    public void AppendNode(LightNode node)
    {
        if (node != null)
        {
            SubNodes.Add(node);
        }
    }

    public override string InnerHTML
    {
        get
        {
            if (SubNodes.Count == 0)
            {
                return string.Empty;
            }

            var builder = new StringBuilder();
            foreach (var node in SubNodes)
            {
                builder.Append(node.OuterHTML);
            }
            return builder.ToString();
        }
    }

    public override string OuterHTML
    {
        get
        {
            string styleAttr = Styles.Count > 0 ? $" class=\"{string.Join(" ", Styles)}\"" : "";
            if (Closing == ClosingType.SelfClosing)
            {
                return $"<{TagName}{styleAttr} />";
            }
            return $"<{TagName}{styleAttr}>{InnerHTML}</{TagName}>";
        }
    }

    public override void DisplayStructure(int indent = 0)
    {
        string styles = Styles.Count > 0 ? $" ({string.Join(", ", Styles)})" : "";
        Console.WriteLine(new string(' ', indent * 2) + $"{TagName}{styles}");
        foreach (var node in SubNodes)
        {
            node.DisplayStructure(indent + 1);
        }
    }
}