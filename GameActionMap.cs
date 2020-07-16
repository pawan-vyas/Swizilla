using System;
using System.IO;
using System.Collections.Generic;
namespace Swizilla
{
  class GameActionMap
  {
    // Function which saves the current
    // game data.
    static void QuickSave()
    {
      string gameData = $"Dummy Game Data\n\t" +
        $"Save Time: {DateTime.Now}" +
        $"\n\tSaved using ActionMap!";
      File.WriteAllText("SevFile.sev", gameData);
      Console.WriteLine("Game data saved!");
    }

    // Function which loads the game
    // data from *.sev file.
    static void QuickLoad()
    {
      string loadedData = File.ReadAllText("SevFile.sev");
      Console.WriteLine($"Saved data loaded from file:" +
        $"\n{loadedData}");
    }

    // Function which opens inventory menu.
    static void OpenInventory()
    {
      Console.WriteLine("Inventory loaded with data:");
      Console.WriteLine("\tHealth Kits: 10" +
        "\tRevive Kits: 5\tBullets: 124");
    }

    // Defining a map which holds
    // Action delegates representing
    // each action from the game.
    static Dictionary<string, Action> gameActionMap
      = new Dictionary<string, Action>()
      {
          { "quicksave", QuickSave },
          { "quickload", QuickLoad },
          { "inventory", OpenInventory }
      };

    static void _Main(string[] args)
    {
      Console.Write("Enter name of action to perform: ");

      // Variable to hold the name of the
      // user provided action to be performed
      string actionName = Console.ReadLine().Trim().ToLower();

      if (gameActionMap.ContainsKey(actionName))
        gameActionMap[actionName]();
        // Or: gameActionMap[actionName].Invoke();
      else
        Console.WriteLine($"No action named: " +
          $"{actionName} exists.");
    }
  }
}
