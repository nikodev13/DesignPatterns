namespace OpenClose;

public class InvoicePersistence
{
    private readonly Invoice _invoice;
    private readonly IInvoiceSaver _invoiceSaver; 
    
    public InvoicePersistence(Invoice invoice, IInvoiceSaver invoiceSaver)
    {
        _invoice = invoice;
        _invoiceSaver = invoiceSaver;
    }

    public void Save()
    {
        _invoiceSaver.Save(_invoice);
    }
    
    // BAD EXAMPLE - CLASS ISN'T CLOSE FOR MODIFICATION
    // public void SaveToPdf()
    // {
    //     Console.WriteLine("Saving to pdf...");
    // }
    //
    // public void SaveToWord()
    // {
    //     Console.WriteLine("Saving to word...");
    // }
}