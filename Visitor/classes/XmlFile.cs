namespace Visitor.classes;

public class XmlFile : IFile
{
    public XmlFile(string filePath)
    {
        FilePath = filePath;
    }

    public string FilePath { get; }

    public void Accept(IFileVisitor visitor)
    {
        visitor.Visit(this);
    }
}