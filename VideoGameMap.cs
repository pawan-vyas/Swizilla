using System;
using System.Collections.Generic;
namespace Swizilla
{
  class VideoGameMap
  {
    static void _Main(string[] args)
    {
      // Defining code to action map.
      var codeActionMap = new Dictionary<int, string>()
      {
        { 12 , "jump" },
        { 23 , "crouch" },
        { 34, "quicksave" },
        { 45, "quickload" },
        { 56, "inventory" },
        { 67, "skilltree" }
      };

      Console.Write("Enter Key Code to get its Action Name: ");

      // Variable used to get name
      // of action assigned to it.
      int keyCode = Convert.ToInt32(Console.ReadLine().Trim());

      // Variable to hold human-readable
      // name of the above keyCode.
      // Default assigned to unknown.
      string actionName = "unknown";

      // Now we'll simply read from the map
      // whether given keyCode exists or not
      // and re-assign the action name to the
      // variable based on its code from map.
      if (codeActionMap.ContainsKey(keyCode))
        actionName = codeActionMap[keyCode];

      Console.WriteLine($"Action assigned to {keyCode}" +
          $" is {actionName}.");
    }
  }
}
