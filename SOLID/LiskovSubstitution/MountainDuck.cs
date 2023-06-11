namespace LiskovSubstitution;

// GOOD IMPLEMENTATION OF ABSTRACTION
public class MountainDuck : Duck
{
	public override void Swim()
	{
		Console.WriteLine("Mountain duck is swimming...");		
	}

	public override void Quack()
	{
		Console.WriteLine("Mountain duck is quacking...");
	}
	
	public override void Fly()
	{
		Console.WriteLine("Mountain duck is flying...");
	}
}