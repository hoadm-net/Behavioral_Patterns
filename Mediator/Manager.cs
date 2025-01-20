namespace Mediator;

public class Manager
{
    private IWorkflowMediator _mediator;

    public Manager(IWorkflowMediator mediator = null)
    {
        _mediator = mediator;
    }
    
    public IWorkflowMediator Mediator
    {
        set => _mediator = value;
    }

    public void HandleRequest()
    {
        Console.WriteLine("[Manager]: Do you approve the request? (yes/no)");

        string userInput = Console.ReadLine()?.Trim().ToLower();

        if (userInput == "yes")
        {
            ApproveRequest();
        }
        else
        {
            RejectRequest();
        }
    }

    private void ApproveRequest()
    {
        Console.WriteLine("[Manager]: Approving request.");
        _mediator.Notify(this, "RequestApproved");
    }

    private void RejectRequest()
    {
        Console.WriteLine("[Manager]: Rejecting request.");
        _mediator.Notify(this, "RequestRejected");
    }
}