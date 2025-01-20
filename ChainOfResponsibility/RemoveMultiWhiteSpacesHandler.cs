using System.Text.RegularExpressions;

namespace ChainOfResponsibility;

public class RemoveMultiWhiteSpacesHandler: TextHandler
{
    public override string Handle(string text)
    {
        text = Regex.Replace(text, "\\s+", " ").Trim();
        return _nextHandler != null ? _nextHandler.Handle(text) : text;
    }
}