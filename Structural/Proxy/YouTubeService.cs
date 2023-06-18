using System.Security.Cryptography;

namespace Proxy;

public class YouTubeService : IYouTubeService
{
	public byte[] GetVideo(int videoId)
	{
		Console.WriteLine($"YouTube service downloading video: `{videoId}`.");
		return RandomNumberGenerator.GetBytes(20);
	}
}