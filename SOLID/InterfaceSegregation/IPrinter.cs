namespace InterfaceSegregation;

public interface IPrinter
{
	void PrintGrey(string content);
	void PrintColor(string content);
}

public interface IScanner
{
	string Scan();
}

public interface IFaxContent
{
	void Fax(string content);
}