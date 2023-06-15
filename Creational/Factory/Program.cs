// See https://aka.ms/new-console-template for more information

using Factory;

var shapeFactory = new ShapeFactory();
Shape shape = shapeFactory.Create(ShapeType.Circle);
shape.Render();
shape = shapeFactory.Create(ShapeType.Triangle);
shape.Render();
