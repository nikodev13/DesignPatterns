namespace Adapter;

public class SmsSender
{
	public void SendSms(string to, string text)
	{
		Console.WriteLine($"Sending SMS to: {to}");
	}
}