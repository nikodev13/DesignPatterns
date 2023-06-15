using AbstractFactory.Contracts;

namespace AbstractFactory.Mac;

public class MacTextBox : ITextBox
{
	public void Render()
	{
		Console.WriteLine("Render mac text box...");
	}

	public void HandleInput(string text)
	{
		Console.WriteLine($"Handle text {text} in mac text box...");
	}
}