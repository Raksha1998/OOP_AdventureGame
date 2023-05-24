Console.WriteLine("Hello! What is your name?");
var name = Console.ReadLine();
if (name == string.Empty)
    name = "No Name";
Console.WriteLine("Wlcome {0}", name);