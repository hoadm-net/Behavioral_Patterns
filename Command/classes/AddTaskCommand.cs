namespace Command;

public class AddTaskCommand : ICommand
{
    private readonly TodoList _todoList;
    private readonly string _taskDescription;

    public AddTaskCommand(TodoList todoList, string taskDescription)
    {
        _todoList = todoList;
        _taskDescription = taskDescription;
    }

    public void Execute()
    {
        _todoList.AddTask(_taskDescription);
    }
    
}
