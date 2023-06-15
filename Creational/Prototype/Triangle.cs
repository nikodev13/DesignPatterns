namespace Prototype;

public class Triangle : Shape
{
	public override void Render()
	{
		Console.WriteLine("Render triangle...");
	}

	// SHALLOW COPY
	public override Shape Clone()
	{
		var clone = (Triangle)MemberwiseClone();
		clone.Border = new Border
		{
			Color = Border.Color,
			Size = Border.Size,
		};

		return clone;
	}
}