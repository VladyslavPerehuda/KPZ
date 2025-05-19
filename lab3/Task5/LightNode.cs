public abstract class LightNode
{
  
    public abstract string OuterHTML { get; }

  
    public abstract string InnerHTML { get; }

   
    public abstract void DisplayStructure(int indent = 0);
}