using System.Threading.Channels;

namespace DependencyInversion;

public class EmailNotification : INotificationSender
{
	public void SendNotification(User user)
	{
		Console.WriteLine($"Sending email notification to {user.Email}.");
	}
}