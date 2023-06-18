using Decorator;

var pizza = new MediumPizza();

var mediumPizzaWithCheese = new CheesePizzaDecorator(pizza);
var mediumPizzaWithHam = new HamPizzaDecorator(mediumPizzaWithCheese);

Console.WriteLine(mediumPizzaWithHam.CalculatePrice());