namespace LiskovSubstitution;

// BAD CLASS HIERARCHY
public class Rectangle
{
	protected int Width;
	protected int Height;

	public Rectangle(int width, int height)
	{
		Width = width;
		Height = height;
	}

	public virtual void SetWidth(int width)
	{
		Width = width;
	}
	
	public virtual void SetHeight(int height)
	{
		height = height;
	}
}

public class Square : Rectangle
{
	public Square(int width, int height) : base(width, height) { }

	public override void SetWidth(int width)
	{
		Width = width;
		Height = width;
	}

	public override void SetHeight(int height)
	{
		Width = height;
		Height = height;
	}
}