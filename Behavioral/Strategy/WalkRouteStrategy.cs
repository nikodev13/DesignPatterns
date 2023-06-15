namespace Strategy;

public class WalkRouteStrategy : IRouteStrategy
{
	public void CreateRoute(Coordinate from, Coordinate to)
	{
		Console.WriteLine("Walk strategy...");
	}
}