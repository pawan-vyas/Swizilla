using System.Collections.Generic;
namespace Swizilla
{
  class LevelLoadMapNew
  {
    // Composing a map of concrete ALevel
    // implementations with their key names.
    static Dictionary<string, ALevel> _levelMap
      = new Dictionary<string, ALevel>()
      {
        { "Sanctum", new Sanctum() },
        { "LazarusLabs", new LazarusLabs() }
        // New key:value to be added for levels
        // as and when they get created. :/
      };

    static void _Main(string[] args)
    {
      string userLevel = "Sanctum";

      // Loading the level using the key from
      // the map.
      ALevel level = _levelMap[userLevel];
      level.Load();
    }
  }
}
