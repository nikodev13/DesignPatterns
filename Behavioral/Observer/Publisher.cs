namespace Observer;

public class Publisher
{
	private List<ISubscriber> _subscribers = new();

	public void Subscribe(ISubscriber subscriber)
	{
		_subscribers.Add(subscriber);
	}

	public void Unsubscribe(ISubscriber subscriber)
	{
		_subscribers.Remove(subscriber);
	}

	public void Update(string context)
	{
		foreach (var subscriber in _subscribers)
		{
			subscriber.Update(context);
		}
	}
}