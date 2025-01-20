namespace Mediator;

public class Employee
{
    private IWorkflowMediator _mediator;

    public Employee(IWorkflowMediator mediator = null)
    {
        _mediator = mediator;
    }

    public IWorkflowMediator Mediator
    {
        set => _mediator = value;
    }

    public void SubmitRequest(string request)
    {
        Console.WriteLine($"[Employee]: Submitting request - {request}");
        _mediator.Notify(this, "RequestSubmitted");
    }
}