namespace State;

public class CardInserted : State
{
	public CardInserted(Context context) : base(context) { }
	
	public override void InsertCard()
	{
		Console.WriteLine("You have already inserted card.");
	}

	public override void EjectCard()
	{
		Console.WriteLine("Card ejected.");
		context.ChangeState(new NoCard(context));
	}

	public override void InsertPin(int pin)
	{
		if (pin == 8888)
		{
			Console.WriteLine("Correct pin inserted.");
			context.ChangeState(new PinInserted(context));

		}
		else
		{
			Console.WriteLine("Incorrect pin inserted");
			Console.WriteLine("Card ejected.");
			context.ChangeState(new NoCard(context));

		}
	}

	public override void WithdrawCash(int amount)
	{
		Console.WriteLine("Insert pin first.");
	}
}