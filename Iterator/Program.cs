using Iterator.classes;

namespace Iterator;

internal class Program
{
    private static void Main(string[] args)
    {
        var students = new StudentCollection();
        students.Add(new Student
            { ID = 1, FirstName = "Bob", LastName = "Johnson", Gender = "Male", YearOfBirth = 1998 });
        students.Add(new Student
            { ID = 2, FirstName = "Alice", LastName = "Smith", Gender = "Female", YearOfBirth = 2000 });
        students.Add(new Student
            { ID = 3, FirstName = "Charlie", LastName = "Brown", Gender = "Male", YearOfBirth = 2002 });


        Console.WriteLine("Default Order (By Entry):");
        var defaultIterator = students.CreateIterator("Default");
        while (defaultIterator.Next()) Console.WriteLine(defaultIterator.Current);

        Console.WriteLine("\nOrder By First Name:");
        var firstNameIterator = students.CreateIterator("FirstName");
        while (firstNameIterator.Next()) Console.WriteLine(firstNameIterator.Current);
    }
}