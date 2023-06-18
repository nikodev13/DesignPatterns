using Proxy;

var youTubeService = new YouTubeService();

youTubeService.GetVideo(100);
youTubeService.GetVideo(100);

var proxyYouTubeService = new YouTubeServiceProxy(youTubeService);
proxyYouTubeService.GetVideo(100);
proxyYouTubeService.GetVideo(100);
