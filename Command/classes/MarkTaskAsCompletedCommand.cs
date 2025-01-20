namespace Command;

public class MarkTaskAsCompletedCommand : ICommand
{
    private readonly string _taskDescription;
    private readonly TodoList _todoList;

    public MarkTaskAsCompletedCommand(TodoList todoList, string taskDescription)
    {
        _todoList = todoList;
        _taskDescription = taskDescription;
    }

    public void Execute()
    {
        _todoList.MarkTaskAsCompleted(_taskDescription);
    }
}