﻿namespace TemplateMethod;

public class PdfGenerator : Generator
{
	protected override void PrepareData()
	{
		Console.WriteLine("Prepare data for pdf...");
	}

	protected override void GenerateFile()
	{
		Console.WriteLine("Generate pdf file...");
	}

	protected override void GetData()
	{
		Console.WriteLine("Pdf get data override...");
	}
}