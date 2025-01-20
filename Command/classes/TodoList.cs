namespace Command;

public class TodoList
{
    private readonly List<Task> _tasks = new();

    public void AddTask(string taskDescription)
    {
        var task = new Task(taskDescription);
        _tasks.Add(task);
        Console.WriteLine($"Task added: {task.Description}");
    }

    public void RemoveTask(string taskDescription)
    {
        var task = _tasks.Find(t => t.Description == taskDescription);
        if (task != null)
        {
            _tasks.Remove(task);
            Console.WriteLine($"Task removed: {task.Description}");
        }
        else
        {
            Console.WriteLine($"Task '{taskDescription}' not found.");
        }
    }

    public void MarkTaskAsCompleted(string taskDescription)
    {
        var task = _tasks.Find(t => t.Description == taskDescription);
        if (task != null)
        {
            task.MarkAsCompleted();
            Console.WriteLine($"Task '{task.Description}' marked as completed.");
        }
        else
        {
            Console.WriteLine($"Task '{taskDescription}' not found.");
        }
    }

    public void ShowTasks()
    {
        Console.WriteLine("Current tasks:");
        foreach (var task in _tasks)
        {
            var status = task.IsCompleted ? "Completed" : "Doing";
            Console.WriteLine($"- {task.Description} [{status}]");
        }

        Console.WriteLine();
    }
}