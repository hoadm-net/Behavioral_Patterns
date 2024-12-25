namespace Visitor.classes;

public class XmlFile : IFile
{
    public string FilePath { get; }

    public XmlFile(string filePath)
    {
        FilePath = filePath;
    }

    public void Accept(IFileVisitor visitor)
    {
        visitor.Visit(this);
    }
}