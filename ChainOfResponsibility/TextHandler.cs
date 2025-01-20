namespace ChainOfResponsibility;

public abstract class TextHandler
{
    protected TextHandler _nextHandler;

    public void SetNextHandler(TextHandler nextHandler)
    {
        _nextHandler = nextHandler;
    }

    public abstract string Handle(string text);
}

