using OpenClose;

// invoice
var invoice = new Invoice("A Sp. z o.o.", "B Sp. z o.o.", new LineItem[]
{
    new("Intel Core i7-11800H", 1200m, 1, 0.23f),
    new("Nvidia RTX 3060", 1200m, 1, 0.23f),
});

var invoiceLogger = new InvoiceLogger(invoice);
invoiceLogger.Display();
var invoicePersistence = new InvoicePersistence(invoice, new PdfInvoiceSaver());
invoicePersistence.Save();

// empty line
Console.WriteLine();

// shapes
var shapes = new Shape[]
{
    new Circle(0, 0, 10),
    new Rectangle(0, 0, 20, 10)
};
RenderContext.Render(shapes);


