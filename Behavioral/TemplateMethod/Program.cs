
using TemplateMethod;

Console.WriteLine("** PDF:");
new PdfGenerator().GenerateReport();
Console.WriteLine("** Csv:");
new CsvGenerator().GenerateReport();
Console.WriteLine("** Excel:");
new ExcelGenerator().GenerateReport();