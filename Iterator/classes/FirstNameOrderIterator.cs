namespace Iterator.classes;

public class FirstNameOrderIterator : IIterator<Student>
{
    private readonly List<Student> _students;
    private int _position = -1;

    public FirstNameOrderIterator(List<Student> students)
    {
        _students = students.OrderBy(s => s.FirstName).ToList();
    }

    public Student Current => _position >= 0 && _position < _students.Count ? _students[_position] : null;

    public bool Next()
    {
        if (_position < _students.Count - 1)
        {
            _position++;
            return true;
        }
        return false;
    }

    public void Reset()
    {
        _position = -1;
    }
}