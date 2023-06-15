using AbstractFactory.Contracts;

namespace AbstractFactory.Windows;

public class WindowsTextBox : ITextBox
{
	public void Render()
	{
		Console.WriteLine("Render windows text box...");
	}

	public void HandleInput(string text)
	{
		Console.WriteLine($"Handle text {text} in windows text box...");
	}
}