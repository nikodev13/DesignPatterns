using AbstractFactory.Contracts;

namespace AbstractFactory;

public class Application
{
	private readonly IUiElementFactory _uiElementFactory;

	public Application(IUiElementFactory uiElementFactory)
	{
		_uiElementFactory = uiElementFactory;
	}

	public void Render()
	{
		var button = _uiElementFactory.CreateButton();
		var textBox = _uiElementFactory.CreateTextBox();
		
		button.Render();
		textBox.Render();
	}
}