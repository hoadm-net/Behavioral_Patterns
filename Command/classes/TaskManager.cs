namespace Command;

public class TaskManager
{
    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
    }
}