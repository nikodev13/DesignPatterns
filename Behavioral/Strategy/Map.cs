namespace Strategy;

public class Map
{
	private readonly IRouteStrategy _routeStrategy;

	public Map(IRouteStrategy routeStrategy)
	{
		_routeStrategy = routeStrategy;
	}
	
	public void CreateRoute(Coordinate from, Coordinate to)
	{
		_routeStrategy.CreateRoute(from, to);
	}
}