using System;
using System.Linq;
using System.Collections.Generic;
using PracticeLinq;

// Create a list of video game names...
List<string> gameNames = new List<string>
{ "League of Legends", "Divnity 2", "Songs of Conquest", "Halo"};
// Order the list of games by length of the game name.
gameNames.OrderBy(game => game.Length).ToList().ForEach(game1 => Console.WriteLine(game1));
// Use the lambda expression in this exercise as well.
// use Method Syntax for this exercise
// Start with your collection, one at a time "What do you want to do?"