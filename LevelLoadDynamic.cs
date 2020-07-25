using System;
using System.IO;
using System.Collections.Generic;
namespace Swizilla
{
  // This class creates concrete objects of ALevel
  // derived classes.
  public class LevelCreator
  {
    // This map contains level key names mapped
    // to the actual implementation class names.
    // It gets populated at runtime. So we never
    // have to modify the code! :)
    static Dictionary<string, string> _classMap
      = new Dictionary<string, string>();

    static LevelCreator()
    {
      // Reading config file contents.
      string[] contents =
        File.ReadAllLines("Levels.doom");

      // Iterating through config file.
      foreach (string line in contents)
      {
        // Split each config entry using '|'
        // to get the key : value separately.
        string[] configEntry = line.Split('|');
        string levelKey = configEntry[0];
        string className = configEntry[1];

        // Adding the key and value to the map
        _classMap.Add(levelKey, className);
      }
    }

    public static ALevel Create(string levelKey)
    {
      // Get the assembly-qualified-className
      // of the passed levelKey, load its type,
      // create & return its object at runtime.
      string className = _classMap[levelKey];

      return (ALevel)Activator
        .CreateInstance(Type.GetType(className));
    }
  }

  class LevelLoadDynamic
  {
    static void Main(string[] args)
    {
      string userLevel = "LazarusLabs";

      // Getting an instance of the desired
      // level using the LevelCreator class.
      ALevel level =
        LevelCreator.Create(userLevel);
      level.Load();
    }
  }
}
