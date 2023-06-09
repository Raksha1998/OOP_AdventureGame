﻿using OOP_GameAdventure;

Text.LoadLanguage(new English());

Console.WriteLine(Text.Language.ChooseYourName);
var name = Console.ReadLine();
if (name == string.Empty)
    name = Text.Language.DefaultName;

var player = new Player(name);

Console.WriteLine(Text.Language.Welcome, player.Name);

var house = new House(player);