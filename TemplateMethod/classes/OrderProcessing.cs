namespace TemplateMethod.classes;

public abstract class OrderProcessing
{
    public void ProcessOrder()
    {
        ValidateOrder();
        ProcessPayment();
        HandleShipping(); // Phần này có thể thay đổi tùy vào loại sản phẩm
        UpdateOrderStatus();
    }

    // Các bước cố định trong quy trình
    protected void ValidateOrder()
    {
        Console.WriteLine("Validating order...");
    }

    protected void ProcessPayment()
    {
        Console.WriteLine("Processing payment...");
    }

    protected void UpdateOrderStatus()
    {
        Console.WriteLine("Updating order status...");
    }

    // Bước có thể thay đổi ở lớp con
    protected abstract void HandleShipping();
}