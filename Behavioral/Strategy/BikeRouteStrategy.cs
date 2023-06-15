namespace Strategy;

public class BikeRouteStrategy : IRouteStrategy
{
	public void CreateRoute(Coordinate from, Coordinate to)
	{
		Console.WriteLine("Bike strategy...");
	}
}