namespace OpenClose;

public class Invoice
{
    public string Vendor { get; }
    public string Vendee { get; }
    public IEnumerable<LineItem> LineItems { get; }
    public decimal Total { get; }

    public Invoice(string vendor, string vendee, IEnumerable<LineItem> lineItems)
    {
        LineItems = lineItems;
        Vendor = vendor;
        Vendee = vendee;
        Total = CalculateTotal();
    }

    // BAD EXAMPLE FOR INVOICE PERSISTENCE 
    // public void Display()
    // {
    //     Console.WriteLine($"Vendor: {Vendor}");
    //     Console.WriteLine($"Vendee: {Vendee}");
    //     Console.WriteLine($"Total: {Total}");
    // }
    //
    // public void SaveToPdf()
    // {
    //     Console.WriteLine("Saving to pdf...");
    // }
    
    private decimal CalculateTotal()
    {
        var total = LineItems
            .Select(x => x.Price * x.Count * (1 + (decimal)x.TaxRate))
            .Sum();

        return total;
    }
}