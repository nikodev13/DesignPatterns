using Builder;

var builder = new InvoiceBuilder();

builder.SetDate(new DateTime(2020, 1, 1))
	.SetInvoiceNumber("A1")
	.SetVendor("Google")
	.SetVendee("Vendee")
	.SetLineItems(new []{ "Line item 1", "Line item 2" });

var invoice = builder.Build();

Console.WriteLine($"{invoice.Vendee} {invoice.Vendor}");	