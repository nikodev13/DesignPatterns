namespace Facade;

public class ScanFacade
{
	private QualityScanner _qualityScanner = new();
	private SecurityScanner _securityScanner = new();
	private DependencyScanner _dependencyScanner = new();
	private ReportGenerator _reportGenerator = new();
	
	public void Scan(string githubUrl)
	{
		Console.WriteLine($"Scanning {githubUrl}:");
		
		var qualityScanErrors = _qualityScanner.QualityScan(githubUrl);
		var securityScanErrors = _securityScanner.SecurityScan(githubUrl);
		var dependencyScanErrors = _dependencyScanner.DependencyScan(githubUrl);

		Console.WriteLine("Generating report:");
		_reportGenerator.GenerateReport(qualityScanErrors, securityScanErrors, dependencyScanErrors);
	}
}