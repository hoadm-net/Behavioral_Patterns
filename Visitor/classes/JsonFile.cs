namespace Visitor.classes;

public class JsonFile : IFile
{
    public string FilePath { get; }

    public JsonFile(string filePath)
    {
        FilePath = filePath;
    }

    public void Accept(IFileVisitor visitor)
    {
        visitor.Visit(this);
    }
}