namespace OpenClose;

public static class RenderContext
{
    public static void Render(IEnumerable<Shape> shapes)
    {
        foreach (var shape in shapes)
        {
            shape.Draw();
        }
    }
}

public abstract class Shape
{
    public uint X { get; set; }
    public uint Y { get; set; }

    public Shape(uint x, uint y)
    {
        X = x;
        Y = y;
    }
    
    internal abstract void Draw();
}

public class Circle : Shape
{
    public uint Radius { get; }
    
    public Circle(uint x, uint y, uint radius) : base(x, y)
    {
        Radius = radius;
    }

    internal override void Draw()
    {
        Console.WriteLine($"Drawing circle(radius: {Radius}) at ({X}, {Y})...");
    }
}

public class Rectangle : Shape
{
    public uint Width { get; }
    public uint Height { get; }

    public Rectangle(uint x, uint y, uint width, uint height) : base(x, y)
    {
        Width = width;
        Height = height;
    }

    internal override void Draw()
    {
        Console.WriteLine($"Drawing rectangle(width: {Width}, height: {Height}) at ({X}, {Y})...");
    }
}