using System;
using System.Collections.Generic;
namespace Swizilla
{
  interface IInteraction
  {
    bool Interact(string action, string data);
  }

  partial class DwarfGateLord : IInteraction
  {
    // Map which will hold all the
    // methods of this class as per
    // the defined Action delegate.
    private Dictionary<string, Action<string>>
      _interactionMap;

    public DwarfGateLord()
    {
      _interactionMap =
      new Dictionary<string, Action<string>>()
      {
        { "Diplomacy", Diplomacy },
        { "Fight", Fight }
      };
    }

    public bool Interact(string action,
      string data)
    {
      bool canInteract
        = _interactionMap.ContainsKey(action);
      if (canInteract)
        _interactionMap[action](data);
      return canInteract;
    }
  }

  class GameNPCMessagePassing
  {
    // Same as GameNPCMap example, but
    // this time using IInteraction
    // interface references instead.
    static Dictionary<string, IInteraction>
      npcMap =
      new Dictionary<string, IInteraction>()
      {
        { "dwarf", new DwarfGateLord() }
        // Similar to GameNPCMap, we can
        // add further more concrete
        // objects in this map.
      };

    static void Main(string[] args)
    {
      string playerRace = "khajiit";
      string interactedNPC = "dwarf";
      string interaction = "Fight";

      // Getting player selected NPC
      // from npcMap and invoking its
      // Interact method.
      if (npcMap.TryGetValue(interactedNPC,
        out IInteraction npc))
        npc.Interact(interaction, playerRace);
    }
  }
}