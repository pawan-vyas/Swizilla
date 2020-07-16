using System;
namespace Swizilla
{
  class GameNPCSwitch
  {
    static void _Main(string[] args)
    {
      // Defines race type of the player.
      string playerRace = "orc";

      // Defines race of NPC player
      // has interacted with.
      string interactedNPC = "dwarf";

      // Defines type of interaction with NPC
      // chosen by player.
      string interaction = "Diplomacy";

      switch (interactedNPC)
      {
        case "dwarf":
          {
            switch (interaction)
            {
              case "Fight":
                {
                  Console.WriteLine($"I will beat you to pulp"
                    + $" silly {playerRace}!");
                  break;
                }
              case "Diplomacy":
                {
                  if ("orc" == playerRace)
                  {
                    Console.WriteLine($"No peace with {playerRace}!");
                    // Code for Fighting,
                    // same as that of case "Fight". :(
                    Console.WriteLine($"I will beat you to pulp"
                      + $" silly {playerRace}!");
                  }
                  else
                    Console.WriteLine($"Yes puny {playerRace}"
                       + $", lets resolve this amicably!");
                  break;
                }
            }
            break;
          }
          // More NPC cases here.
      }
    }
  }
}
