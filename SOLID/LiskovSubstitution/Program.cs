using LiskovSubstitution;

var cityDuck = new CityDuck();
var rubberDuck = new RubberDuck();

DuckAction(cityDuck);

try
{
	DuckAction(rubberDuck);
}
catch (InvalidOperationException e)
{
	Console.WriteLine("Exception: Rubber duck cannot fly...");
}

static void DuckAction(Duck duck)
{
	duck.Swim();
	duck.Quack();
	duck.Fly();
}