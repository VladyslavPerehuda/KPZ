
public class ElementFactory
{
    private Dictionary<string, ElementIntrinsicState> _cache = new Dictionary<string, ElementIntrinsicState>();

    public ElementIntrinsicState GetIntrinsicState(string tagName, DisplayType display, ClosingType closing)
    {
        string key = $"{tagName}-{display}-{closing}";
        if (!_cache.ContainsKey(key))
        {
            var state = new ElementIntrinsicState(tagName, display, closing);
            _cache[key] = state;
        }
        return _cache[key];
    }

    public int CachedCount => _cache.Count;
}