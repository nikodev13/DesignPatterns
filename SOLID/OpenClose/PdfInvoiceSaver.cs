namespace OpenClose;

public class PdfInvoiceSaver : IInvoiceSaver
{
    public void Save(Invoice invoice)
    {
        Console.WriteLine($"Saving invoice to pdf... (vendor: {invoice.Vendor})");
    }
}