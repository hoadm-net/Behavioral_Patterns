namespace Visitor.classes;

public class TextFile : IFile
{
    public string FilePath { get; }

    public TextFile(string filePath)
    {
        FilePath = filePath;
    }

    public void Accept(IFileVisitor visitor)
    {
        visitor.Visit(this);
    }
}