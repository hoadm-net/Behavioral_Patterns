using System.Text.RegularExpressions;

namespace ChainOfResponsibility;

public class RemovePunctuationHandler: TextHandler
{
    public override string Handle(string text)
    {
        text = Regex.Replace(text, "[\\p{P}-[.]]", "");
        return _nextHandler != null ? _nextHandler.Handle(text) : text;
    }
}