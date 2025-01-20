namespace Mediator;

public interface IWorkflowMediator
{
    void Notify(object sender, string eventCode);
}