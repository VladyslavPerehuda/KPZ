public class LightTextNode : LightNode
{
    private readonly string _value;

   
    public LightTextNode(string value)
    {
        _value = value ?? throw new ArgumentNullException(nameof(value), "Текстовий вміст не може бути null.");
    }

    public override string InnerHTML => _value;

    public override string OuterHTML => _value;

    public override void DisplayStructure(int indent = 0)
    {
        Console.WriteLine(new string(' ', indent * 2) + $"Text: {_value}");
    }
}