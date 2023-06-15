using AbstractFactory.Contracts;

namespace AbstractFactory.Mac;

public class MacUiElementFactory : IUiElementFactory
{
	public IButton CreateButton() => new MacButton();

	public ITextBox CreateTextBox() => new MacTextBox();
}