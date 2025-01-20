namespace Mediator;

public class WorkflowMediator : IWorkflowMediator
{
    private Employee _employee;
    private Manager _manager;
    private Finance _finance;

    public WorkflowMediator(Employee employee, Manager manager, Finance finance)
    {
        _employee = employee;
        _manager = manager;
        _finance = finance;

    }
    
    public void Notify(object sender, string eventCode)
    {
        if (eventCode == "RequestSubmitted")
        {
            Console.WriteLine("[Mediator]: Request submitted. Forwarding to Manager.");
            _manager.HandleRequest();
        }
        else if (eventCode == "RequestApproved")
        {
            Console.WriteLine("[Mediator]: Request approved. Forwarding to Finance.");
            _finance.ProcessPayment();
        }
        else if (eventCode == "RequestRejected")
        {
            Console.WriteLine("[Mediator]: Request rejected. Workflow stopped.");
        }
        else if (eventCode == "PaymentProcessed")
        {
            Console.WriteLine("[Mediator]: Payment processed. Workflow complete.");
        }
    }
}