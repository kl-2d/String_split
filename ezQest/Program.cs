string value = "Volodimir Singapuk <singapuk.e03@gmail.com>";
string userName = "";
string email = "";
string[] items = value.Split('<', '>');
userName = items[0];
email = items[1];

Console.WriteLine($"Username: {userName}");
Console.WriteLine($"User mail: {email}");

