using System.Text.Json;
using System.Xml.Linq;

namespace Visitor.classes;

public class FileToStudentConverter : IFileVisitor
{
    public List<Student> Students { get; } = new();

    public void Visit(TextFile textFile)
    {
        Console.WriteLine($"Reading Text File: {textFile.FilePath}");
        var lines = File.ReadAllLines(textFile.FilePath);
        for (var i = 0; i < lines.Length; i += 4)
        {
            string[] data = lines[i].Split(',');
            Students.Add(new Student
            {
                ID = data[0].Trim(),
                FullName = data[1].Trim(),
                Gender = data[2].Trim(),
                YearOfBirth = int.Parse(data[3].Trim())
            });
        }
    }

    public void Visit(JsonFile jsonFile)
    {
        Console.WriteLine($"Reading JSON File: {jsonFile.FilePath}");
        var content = File.ReadAllText(jsonFile.FilePath);
        var students = JsonSerializer.Deserialize<List<Student>>(content);
        if (students != null) Students.AddRange(students);
    }

    public void Visit(XmlFile xmlFile)
    {
        Console.WriteLine($"Reading XML File: {xmlFile.FilePath}");
        var xDoc = XDocument.Load(xmlFile.FilePath);
        var elements = xDoc.Descendants("Student");
        foreach (var element in elements)
            Students.Add(new Student
            {
                ID = element.Element("ID")?.Value,
                FullName = element.Element("FullName")?.Value,
                Gender = element.Element("Gender")?.Value,
                YearOfBirth = int.Parse(element.Element("YearOfBirth")?.Value)
            });
    }
}