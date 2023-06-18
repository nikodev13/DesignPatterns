namespace State;

public class Context
{
	private State _currentState;

	public Context()
	{
		_currentState = new NoCard(this);
	}

	public int AvailableCash { get; set; } = 1000;

	public void ChangeState(State state)
	{
		_currentState = state;
	} 

	public void InsertCard()
	{
		_currentState.InsertCard();;
	}

	public void EjectCard()
	{
		_currentState.EjectCard();
	}

	public void InsertPin(int pin)
	{
		_currentState.InsertPin(pin);
	}

	public void WithdrawCash(int amount)
	{
		_currentState.WithdrawCash(amount);
	}
}