namespace LiskovSubstitution;

// BAD IMPLEMENTATION OF ABSTRACTION
public class RubberDuck : Duck
{
	public override void Swim()
	{
		Console.WriteLine("Rubber duck is swimming...");		
	}

	public override void Quack()
	{
		Console.WriteLine("Rubber duck is quacking...");
	}
	
	public override void Fly()
	{
		throw new InvalidOperationException();
	}
}