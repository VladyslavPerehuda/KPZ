public abstract class SupportHandler
{
    protected SupportHandler nextHandler;

    public void SetNextHandler(SupportHandler handler)
    {
        nextHandler = handler;
    }

    public abstract void HandleRequest(int level);
}
