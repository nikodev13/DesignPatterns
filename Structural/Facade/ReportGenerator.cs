namespace Facade;

public class ReportGenerator
{
	public void GenerateReport(IEnumerable<string> qualityScanErrors, IEnumerable<string> securityScanErrors, IEnumerable<string> dependencyScanErrors)
	{
		Console.WriteLine("Quality scan errors: ");
		Console.WriteLine(string.Join(',', qualityScanErrors));
		
		Console.WriteLine("Security scan errors: ");
		Console.WriteLine(string.Join(',', securityScanErrors));
		
		Console.WriteLine("Dependency scan errors: ");
		Console.WriteLine(string.Join(',', dependencyScanErrors));
	}
}