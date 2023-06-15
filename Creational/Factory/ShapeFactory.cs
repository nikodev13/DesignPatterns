namespace Factory;

public enum ShapeType
{
	Circle,
	Triangle,
	Rectangle,
}

public class ShapeFactory
{
	public Shape Create(ShapeType shapeType)
	{
		return shapeType switch
		{
			ShapeType.Circle => new Circle(),
			ShapeType.Triangle => new Triangle(),
			ShapeType.Rectangle => new Rectangle(),
			_ => throw new ArgumentOutOfRangeException(nameof(shapeType), shapeType, null),
		};
	}
}