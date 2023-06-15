namespace Singleton;

public class Configuration
{
	private static Configuration? _instance;
	private static object _lockObj = new();

	private Configuration()
	{
		_instance = this;
	}

	public static Configuration GetInstance()
	{
		lock (_lockObj)
		{
			_instance ??= new Configuration();
		}
		
		return _instance;
	}
}