namespace Proxy;

public class YouTubeServiceProxy : IYouTubeService
{
	private readonly IYouTubeService _youTubeService;

	private readonly Dictionary<int, byte[]> _videoCache = new();

	public YouTubeServiceProxy(IYouTubeService youTubeService)
	{
		_youTubeService = youTubeService;
	}
	
	public byte[] GetVideo(int videoId)
	{
		Console.WriteLine($"YouTube proxy getting video: `{videoId}`.");

		if (_videoCache.TryGetValue(videoId, out var cachedVideo))
		{
			return cachedVideo;
		}
		var	video = _youTubeService.GetVideo(videoId);
		_videoCache.Add(videoId, video);
		
		return video;
	}
}