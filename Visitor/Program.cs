using Visitor.classes;

namespace Visitor;

internal class Program
{
    private static void Main(string[] args)
    {
        var textFile = new TextFile("../../../data/students.txt");
        var jsonFile = new JsonFile("../../../data/students.json");
        var xmlFile = new XmlFile("../../../data/students.xml");

        // File collection
        var files = new IFile[] { textFile, jsonFile, xmlFile };

        // Process files
        var converter = new FileToStudentConverter();
        foreach (var file in files) file.Accept(converter);

        // Display the results
        Console.WriteLine("\nConverted Students:");
        foreach (var student in converter.Students) Console.WriteLine(student);
    }
}