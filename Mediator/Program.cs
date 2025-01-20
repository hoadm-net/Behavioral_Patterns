namespace Mediator;

internal class Program
{
    private static void Main(string[] args)
    {
        Employee employee = new Employee();
        Manager manager = new Manager();
        Finance finance = new Finance();
        
        WorkflowMediator mediator = new WorkflowMediator(employee, manager, finance);
        
        employee.Mediator = mediator;
        manager.Mediator = mediator;
        finance.Mediator = mediator;
        
        employee.SubmitRequest("Request for new laptop");
    }
}