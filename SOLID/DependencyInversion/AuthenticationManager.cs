namespace DependencyInversion;

public class AuthenticationManager
{
	private readonly INotificationSender _notificationSender;

	public AuthenticationManager(INotificationSender notificationSender)
	{
		_notificationSender = notificationSender;
	}
	
	public void Authenticate(User user, string email, string password)
	{
		if (user.Email != email || user.Password != password) return;
		Console.WriteLine($"User {user.Name} authenticated!");
		_notificationSender.SendNotification(user);
	}
}