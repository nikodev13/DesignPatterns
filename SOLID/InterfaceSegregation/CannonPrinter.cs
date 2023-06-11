namespace InterfaceSegregation;

// THIS CANNOT SCAN SO "Scan()" METHOD CANNOT BE IN "IPrinter" CONTRACT
public class CannonPrinter : IPrinter, IFaxContent
{
	public void PrintGrey(string content)
	{
		Console.WriteLine("Canon print grey.");
	}

	public void PrintColor(string content)
	{
		Console.WriteLine("Canon print color.");
	}

	public void Fax(string content)
	{
		Console.WriteLine("Canon fax.");
	}
}