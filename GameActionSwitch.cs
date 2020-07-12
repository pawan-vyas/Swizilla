using System;
using System.IO;
namespace Swizilla
{
  class GameActionSwitch
  {
    static void Main(string[] args)
    {
      Console.Write("Enter name of action to perform: ");

      // Variable to hold the name of the
      // action entered which will be used
      // execute that specific code.
      string actionName = Console.ReadLine().Trim().ToLower();

      // Using switch-case to find which
      // action is to be executed.
      switch (actionName)
      {
        case "quicksave":
          string gameData = $"Dummy Game Data\n\t" +
            $"Save Time: {DateTime.Now}" +
            $"\n\tSaved using switch-case.";
          File.WriteAllText("SevFile.sev", gameData);
          Console.WriteLine("Game data saved!");
          break;

        case "quickload":
          string loadedData = File.ReadAllText("SevFile.sev");
          Console.WriteLine($"Saved data loaded from file:" +
            $"\n{loadedData}");
          break;

        case "inventory":
          Console.WriteLine("Inventory loaded with data:");
          Console.WriteLine("\tHealth Kits: 10" +
            "\tRevive Kits: 5\tBullets: 124");
          break;

        default:
          Console.WriteLine($"No action named:" +
            $"{actionName} exists.");
          break;
      }
    }
  }
}
