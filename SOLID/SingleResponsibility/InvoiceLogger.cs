namespace SingleResponsibility;

public class InvoiceLogger
{
    private readonly Invoice _invoice;

    public InvoiceLogger(Invoice invoice)
    {
        _invoice = invoice;
    }
    
    public void Display()
    {
        Console.WriteLine($"Vendor: {_invoice.Vendor}");
        Console.WriteLine($"Vendee: {_invoice.Vendee}");
        Console.WriteLine($"Total: {_invoice.Total}");
    }
}