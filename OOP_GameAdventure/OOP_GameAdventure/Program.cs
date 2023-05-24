using OOP_GameAdventure;


var language = new English();


Console.WriteLine(language.ChooseYourName);
var name = Console.ReadLine();
if (name == string.Empty)
    name = "No Name";

var player = new Player(name);

Console.WriteLine("Welcome {0}", player.Name);