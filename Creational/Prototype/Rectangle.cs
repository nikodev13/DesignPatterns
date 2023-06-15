namespace Prototype;

public class Rectangle : Shape
{
	public override void Render()
	{
		Console.WriteLine("Render rectangle...");
	}

	public override Shape Clone()
	{
		var clone = (Rectangle)MemberwiseClone();
		clone.Border = new Border
		{
			Color = Border.Color,
			Size = Border.Size,
		};

		return clone;
	}
}