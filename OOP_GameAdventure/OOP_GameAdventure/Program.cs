using OOP_GameAdventure;

Console.WriteLine("Hello! What is your name?");
var name = Console.ReadLine();
if (name == string.Empty)
    name = "No Name";

var player = new Player(name);

Console.WriteLine("Welcome {0}", player.Name);