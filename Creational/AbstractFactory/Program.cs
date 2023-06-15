
using AbstractFactory;
using AbstractFactory.Windows;

var app = new Application(new WindowsUiElementFactory());

app.Render();