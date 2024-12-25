namespace Visitor.classes;

public interface IFileVisitor
{
    void Visit(TextFile textFile);
    void Visit(JsonFile jsonFile);
    void Visit(XmlFile xmlFile);
}