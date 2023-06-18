namespace Facade;

public class SecurityScanner
{
	public IEnumerable<string> SecurityScan(string githubUrl)
	{
		Console.WriteLine("Security scan");

		return new[]
		{
			"Security error1",
		};
	}
}