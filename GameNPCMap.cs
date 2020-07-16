using System;
using System.Collections.Generic;
namespace Swizilla
{
  interface INonPlayableCharacter
  {
    void Diplomacy(string playerRace);
    void Fight(string playerRace);
  }

  class DwarfGateLord : INonPlayableCharacter
  {
    public void Diplomacy(string playerRace)
    {
      if ("orc" == playerRace)
      {
        Console.WriteLine($"No peace with {playerRace}!");
        Fight(playerRace);
      }
      else
        Console.WriteLine($"Yes puny {playerRace}"
           + $", lets resolve this amicably!");
    }

    public void Fight(string playerRace)
    {
      Console.WriteLine($"Now I will beat you to"
        + $" pulp silly {playerRace}!");
    }
  }

  class GameNPCMap
  {
    // Map which holds objects of available 
    // NPC classes. But being referenced by
    // INonPlayableCharacter.
    static Dictionary<string, INonPlayableCharacter>
      npcMap =
      new Dictionary<string, INonPlayableCharacter>()
      {
        { "dwarf", new DwarfGateLord() }
        // More NPC mappings here.
      };

    static void _Main(string[] args)
    {
      string playerRace = "orc";
      string interactedNPC = "dwarf";
      string interaction = "Diplomacy";

      // Getting player selected NPC
      // from npcMap.
      if (npcMap.TryGetValue(interactedNPC,
        out INonPlayableCharacter npc))
      {
        // Using Reflection, invoking the
        // player selected interaction
        // on the selected NPC object.
        npc.GetType()
          .GetMethod(interaction)
          .Invoke(
              // Object on which to invoke
              // the method, basically "this"
              npc,

              // Parameters required by the method.
              // Has to be object[], and elements in
              // same sequence as Method signature.
              new object[] { playerRace }
            );
      }
    }
  }
}
