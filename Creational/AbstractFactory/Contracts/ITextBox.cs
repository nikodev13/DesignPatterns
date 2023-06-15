namespace AbstractFactory.Contracts;

public interface ITextBox
{
	void Render();
	void HandleInput(string text);
}