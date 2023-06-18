namespace State;

public abstract class State
{
	protected Context context;

	protected State(Context context)
	{
		this.context = context;
	}

	public abstract void InsertCard();
	public abstract void EjectCard();
	public abstract void InsertPin(int pin);
	public abstract void WithdrawCash(int amount);
}