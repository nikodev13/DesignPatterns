using Singleton;

var cfg1 = Configuration.GetInstance();
var cfg2 = Configuration.GetInstance();

Console.WriteLine($"reference equals: {ReferenceEquals(cfg1, cfg2)}");
