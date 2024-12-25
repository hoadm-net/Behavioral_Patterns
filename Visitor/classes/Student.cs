namespace Visitor.classes;

public class Student
{
    public string ID { get; set; }
    public string FullName { get; set; }
    public string Gender { get; set; }
    public int YearOfBirth { get; set; }

    public override string ToString()
    {
        return $"{ID}, {FullName}, {Gender}, {YearOfBirth}";
    }
}