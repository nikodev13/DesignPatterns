namespace State;

public class PinInserted : State
{
	public PinInserted(Context context) : base(context) { }
	public override void InsertCard()
	{
		Console.WriteLine("You have already inserted a card.");
	}

	public override void EjectCard()
	{
		Console.WriteLine("Card ejected.");
		context.ChangeState(new NoCard(context));
	}

	public override void InsertPin(int pin)
	{
		Console.WriteLine("You have already inserted correct pin.");
	}

	public override void WithdrawCash(int amount)
	{
		if (amount > context.AvailableCash)
		{
			Console.WriteLine("That amount of cash is not available.");	
		}
		else
		{
			Console.WriteLine($"You have withdraw {amount} from the machine.");
			context.AvailableCash -= amount;

			if (context.AvailableCash == 0)
			{
				context.ChangeState(new NoCash(context));
			}
			else
			{
				Console.WriteLine("Card ejected.");
				context.ChangeState(new NoCard(context));
			}
		}
	}
}