namespace Mediator;

public class RegisterClientView : IMediator
{
	private readonly CheckBox _clientType;
	private readonly Button _submitButton;

	public RegisterClientView(CheckBox clientType, Button submitButton)
	{
		_clientType = clientType;
		_submitButton = submitButton;
		
		_clientType.SetMediator(this);
		_submitButton.SetMediator(this);
	}

	public void Notify(Component sender, string @event)
	{
		switch (@event)
		{
			case "checkBoxSelected":
				_submitButton.Render();;
				break;
			case "click":
				_clientType.SaveValue();
				break;
		}
	}
}