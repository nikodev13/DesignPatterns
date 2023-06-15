namespace Prototype;

public class Circle : Shape
{
	public int Radius { get; set; }
	
	public override void Render()
	{
		Console.WriteLine("Render circle...");
	}

	public override Shape Clone()
	{
		var clone = (Circle)MemberwiseClone();
		clone.Border = new Border
		{
			Color = Border.Color,
			Size = Border.Size,
		};

		return clone;
	}
}