
using Mediator;

var checkBox = new CheckBox();
var button = new Button();

_ = new RegisterClientView(checkBox, button);

checkBox.Select();
button.Click();

