using Observer;

var subscriber1 = new Subscriber("sub1");
var subscriber2 = new Subscriber("sub2");

var publisher = new Publisher();

publisher.Subscribe(subscriber1);
publisher.Subscribe(subscriber2);

publisher.Update("asjfbsiadfbndsalkn");

publisher.Unsubscribe(subscriber2);

publisher.Update("aasdbl");