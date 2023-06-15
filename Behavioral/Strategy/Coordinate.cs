namespace Strategy;

public struct Coordinate
{
	public int Longitude { get; set; }
	public int Latitude { get; set; }

	public Coordinate(int longitude, int latitude)
	{
		Longitude = longitude;
		Latitude = latitude;
	}
}