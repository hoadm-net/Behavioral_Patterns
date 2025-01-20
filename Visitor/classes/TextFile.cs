namespace Visitor.classes;

public class TextFile : IFile
{
    public TextFile(string filePath)
    {
        FilePath = filePath;
    }

    public string FilePath { get; }

    public void Accept(IFileVisitor visitor)
    {
        visitor.Visit(this);
    }
}