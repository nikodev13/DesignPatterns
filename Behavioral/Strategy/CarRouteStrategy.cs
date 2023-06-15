namespace Strategy;

public class CarRouteStrategy : IRouteStrategy
{
	public void CreateRoute(Coordinate from, Coordinate to)
	{
		Console.WriteLine("Car strategy...");
	}
}