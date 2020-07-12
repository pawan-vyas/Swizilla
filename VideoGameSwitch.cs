using System;
namespace Swizilla
{
  class VideoGameSwitch
  {
    static void Main(string[] args)
    {
      Console.Write("Enter Key Code to get its Action Name: ");

      // Variable used to get name
      // of action assigned to it.
      int keyCode = Convert.ToInt32(Console.ReadLine().Trim());

      // Variable to hold human-readable
      // name of the above keyCode.
      string actionName;

      // Using switch-case to get the
      // keyCode's mappingName.
      switch (keyCode)
      {
        case 12:
          actionName = "jump";
          break;
        case 23:
          actionName = "crouch";
          break;
        case 34:
          actionName = "quicksave";
          break;
        case 45:
          actionName = "quickload";
          break;
        case 56:
          actionName = "inventory";
          break;
        case 67:
          actionName = "skilltree";
          break;
        default:
          actionName = "unknown";
          break;
      }

      Console.WriteLine($"Action assigned to {keyCode}" +
          $" is {actionName}.");
    }
  }
}
