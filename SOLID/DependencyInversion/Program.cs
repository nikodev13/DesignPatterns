using DependencyInversion;

var user = new User
{
	Name = "Nikodem",
	Email = "nikodem.rekiewicz@outlook.com",
	Password = "empty",
	PhoneNumber = "+48 514 695 703",
};

var emailNotification = new EmailNotification();
var authenticationManager = new AuthenticationManager(emailNotification);

authenticationManager.Authenticate(user, user.Email, user.Password);