namespace Factory;

public abstract class Shape
{
	public int X { get; set; } = 0;
	public int Y { get; set; } = 0;
	public abstract void Render();
}