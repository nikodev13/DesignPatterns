using AbstractFactory.Contracts;

namespace AbstractFactory.Mac;

public class MacButton : IButton
{
	public void Click()
	{
		Console.WriteLine("Mac button clicked...");
	}

	public void Render()
	{
		Console.WriteLine("Render mac button...");
	}
}