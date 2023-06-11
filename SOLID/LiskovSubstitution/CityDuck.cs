namespace LiskovSubstitution;

// GOOD IMPLEMENTATION OF ABSTRACTION
public class CityDuck : Duck
{
	public override void Swim()
	{
		Console.WriteLine("City duck is swimming...");		
	}

	public override void Quack()
	{
		Console.WriteLine("City duck is quacking...");
	}

	public override void Fly()
	{
		Console.WriteLine("City duck is flying...");
	}
}