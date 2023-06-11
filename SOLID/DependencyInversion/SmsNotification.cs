namespace DependencyInversion;

public class SmsNotification : INotificationSender
{
	public void SendNotification(User user)
	{
		Console.WriteLine($"Sending sms notification to {user.PhoneNumber}.");
	}
}