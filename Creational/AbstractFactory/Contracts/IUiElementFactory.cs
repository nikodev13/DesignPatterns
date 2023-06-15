namespace AbstractFactory.Contracts;

public interface IUiElementFactory
{
	IButton CreateButton();
	ITextBox CreateTextBox();
}