namespace Visitor.classes;

public interface IFile
{
    void Accept(IFileVisitor visitor);
}