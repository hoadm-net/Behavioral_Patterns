namespace Command;

public class Task
{
    public string Description { get; set; }
    public bool IsCompleted { get; private set; }

    public Task(string description)
    {
        Description = description;
        IsCompleted = false;
    }

    public void MarkAsCompleted()
    {
        IsCompleted = true;
    }
}