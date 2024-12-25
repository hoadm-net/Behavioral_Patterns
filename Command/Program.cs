namespace Command;

class Program
{
    static void Main(string[] args)
    {
        TodoList todoList = new TodoList();
        TaskManager taskManager = new TaskManager();

        // Add new tasks
        ICommand addTask1 = new AddTaskCommand(todoList, "Buy groceries");
        ICommand addTask2 = new AddTaskCommand(todoList, "Finish homework");
        taskManager.ExecuteCommand(addTask1); // Output: Task added: Buy groceries
        taskManager.ExecuteCommand(addTask2); // Output: Task added: Finish homework
        todoList.ShowTasks();

        // Complete a task
        ICommand markTaskCompleted = new MarkTaskAsCompletedCommand(todoList, "Buy groceries");
        taskManager.ExecuteCommand(markTaskCompleted); // Output: Task 'Buy groceries' marked as completed.
        todoList.ShowTasks();

        // Remove a task
        ICommand removeTask = new RemoveTaskCommand(todoList, "Finish homework");
        taskManager.ExecuteCommand(removeTask); // Output: Task removed: Finish homework
        todoList.ShowTasks();
        
    }
}