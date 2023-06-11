namespace InterfaceSegregation;

public class HpPrinter : IPrinter, IScanner, IFaxContent
{
	public void PrintGrey(string content)
	{
		Console.WriteLine("Hp print grey.");
	}

	public void PrintColor(string content)
	{
		Console.WriteLine("Hp print color.");
	}

	public string Scan()
	{
		return "Hp scan content.";
	}

	public void Fax(string content)
	{
		Console.WriteLine("Hp fax.");
	}
}