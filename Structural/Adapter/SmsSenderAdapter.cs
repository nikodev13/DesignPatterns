namespace Adapter;

public class SmsSenderAdapter : INotificationSender
{
	private SmsSender _smsSender = new();
	
	public void SendNotification(int userId, Notification notification)
	{
		var phoneNumber = userId * 100;
		_smsSender.SendSms(phoneNumber.ToString(), $"{notification.Title}: {notification.Body}");
	}
}