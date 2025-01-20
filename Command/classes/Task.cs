namespace Command;

public class Task
{
    public Task(string description)
    {
        Description = description;
        IsCompleted = false;
    }

    public string Description { get; set; }
    public bool IsCompleted { get; private set; }

    public void MarkAsCompleted()
    {
        IsCompleted = true;
    }
}