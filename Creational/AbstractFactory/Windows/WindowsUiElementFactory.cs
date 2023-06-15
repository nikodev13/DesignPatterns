using AbstractFactory.Contracts;

namespace AbstractFactory.Windows;

public class WindowsUiElementFactory : IUiElementFactory
{
	public IButton CreateButton() => new WindowsButton();

	public ITextBox CreateTextBox() => new WindowsTextBox();
}