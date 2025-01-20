namespace Mediator;

public class Finance
{
    private IWorkflowMediator _mediator;

    public Finance(IWorkflowMediator mediator = null)
    {
        _mediator = mediator;
    }
    
    public IWorkflowMediator Mediator
    {
        set => _mediator = value;
    }

    public void ProcessPayment()
    {
        Console.WriteLine("[Finance]: Processing payment.");
        _mediator.Notify(this, "PaymentProcessed");
    }
}