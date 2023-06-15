using Prototype;

var circle1 = new Circle()
{
	Radius = 5,
	X = 1,
	Y = 2,
	Border = new Border()
	{
		Color = "blue",
		Size = "4px"
	} 
};

var circle2 = (Circle)circle1.Clone();

Console.WriteLine($"circle reference equals {ReferenceEquals(circle1, circle2)}");
Console.WriteLine($"border reference equals {ReferenceEquals(circle1.Border, circle2.Border)}");
