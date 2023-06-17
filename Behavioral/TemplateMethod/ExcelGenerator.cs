namespace TemplateMethod;

public class ExcelGenerator : Generator
{
	protected override void PrepareData()
	{
		Console.WriteLine("Prepare data for excel...");
	}

	protected override void GenerateFile()
	{
		Console.WriteLine("Generate excel file");
	}
}