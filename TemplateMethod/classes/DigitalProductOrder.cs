namespace TemplateMethod.classes;

public class DigitalProductOrder : OrderProcessing
{
    protected override void HandleShipping()
    {
        Console.WriteLine("Handling shipping for digital product...");
        Console.WriteLine("Sending download link to customer...");
    }
}