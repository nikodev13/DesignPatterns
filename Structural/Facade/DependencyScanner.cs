namespace Facade;

public class DependencyScanner
{
	public IEnumerable<string> DependencyScan(string? githubUrl)
	{
		Console.WriteLine("Dependency scan...");

		return new[]
		{
			"Dependency scan error1"
		};
	}
}