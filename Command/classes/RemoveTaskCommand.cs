namespace Command;

public class RemoveTaskCommand : ICommand
{
    private readonly TodoList _todoList;
    private readonly string _taskDescription;

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