namespace Command;

public class RemoveTaskCommand : ICommand
{
    private readonly string _taskDescription;
    private readonly TodoList _todoList;

    public RemoveTaskCommand(TodoList todoList, string taskDescription)
    {
        _todoList = todoList;
        _taskDescription = taskDescription;
    }

    public void Execute()
    {
        _todoList.RemoveTask(_taskDescription);
    }
}