namespace TemplateMethod.classes;

public class PhysicalProductOrder : OrderProcessing
{
    protected override void HandleShipping()
    {
        Console.WriteLine("Handling shipping for physical product...");
        Console.WriteLine("Arranging delivery to customer address...");
    }
}