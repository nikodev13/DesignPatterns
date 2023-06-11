using InterfaceSegregation;

var hpPrinter = new HpPrinter() as IScanner;
var scanContent = hpPrinter.Scan();
Console.WriteLine(scanContent);

var canonPrinter = new CannonPrinter() as IFaxContent;
canonPrinter.Fax("fax content");
