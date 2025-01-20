namespace Visitor.classes;

public class JsonFile : IFile
{
    public JsonFile(string filePath)
    {
        FilePath = filePath;
    }

    public string FilePath { get; }

    public void Accept(IFileVisitor visitor)
    {
        visitor.Visit(this);
    }
}