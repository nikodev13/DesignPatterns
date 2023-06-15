using System.Threading.Channels;
using AbstractFactory.Contracts;

namespace AbstractFactory.Windows;

public class WindowsButton : IButton
{
	public void Click()
	{
		Console.WriteLine("Windows button clicked...");
	}

	public void Render()
	{
		Console.WriteLine("Render windows button...");
	}
}