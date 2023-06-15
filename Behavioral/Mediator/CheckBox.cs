namespace Mediator;

public class CheckBox : Component
{
	public void Select()
	{
		Console.WriteLine("checkbox selected");
		
		mediator?.Notify(this, "checkBoxSelected");
	}

	public void SaveValue()
	{
		Console.WriteLine("checkbox value saved");
	}
}