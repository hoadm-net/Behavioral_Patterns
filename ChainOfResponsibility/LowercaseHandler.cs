namespace ChainOfResponsibility;

public class LowercaseHandler: TextHandler
{
    public override string Handle(string text)
    {
        text = text.ToLower();
        return _nextHandler != null ? _nextHandler.Handle(text) : text;
    }
}