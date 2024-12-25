using TemplateMethod.classes;

namespace TemplateMethod;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Processing physical product order:");
        OrderProcessing physicalOrder = new PhysicalProductOrder();
        physicalOrder.ProcessOrder();

        Console.WriteLine();

        // Xử lý đơn hàng sản phẩm kỹ thuật số
        Console.WriteLine("Processing digital product order:");
        OrderProcessing digitalOrder = new DigitalProductOrder();
        digitalOrder.ProcessOrder();
    }
}