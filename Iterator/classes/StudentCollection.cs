namespace Iterator.classes;

public class StudentCollection : IAggregate<Student>
{
    private readonly List<Student> _students = new();

    public IIterator<Student> CreateIterator(string order)
    {
        return order switch
        {
            "FirstName" => new FirstNameOrderIterator(_students),
            _ => new DefaultOrderIterator(_students)
        };
    }

    public void Add(Student student)
    {
        _students.Add(student);
    }
}