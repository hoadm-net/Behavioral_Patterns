namespace Iterator.classes;

public class Student
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public int YearOfBirth { get; set; }

    public override string ToString()
    {
        return $"{ID}, {FirstName} {LastName}, {Gender}, {YearOfBirth}";
    }
}