using System;
namespace Swizilla
{
  public abstract class ALevel
  {
    // Some common data across levels.
    protected bool _hasBoss;

    protected ALevel(bool hasBoss)
      => _hasBoss = hasBoss;

    // Abstract method so each level class
    // can implement its own loading strategy.
    abstract public void Load();
  }

  public class Sanctum : ALevel
  {
    // This level has no Boss.
    public Sanctum() : base(false) { }

    public override void Load()
        => Console.WriteLine($"Level loaded!" +
            $" Has boss: {_hasBoss}");
  }

  public class LazarusLabs : ALevel
  {
    // This level has a Boss!
    const string _BOSS = "Cyberdemon";

    public LazarusLabs() : base(true) { }

    public override void Load()
        => Console.WriteLine($"Level loaded!" +
            $" Has boss: {_hasBoss}" +
            $" Name: {_BOSS}!");
  }

  class LevelLoadSwitchNew
  {
    static void Main(string[] args)
    {
      string userLevel = "LazarusLabs";

      // Loading user level using Switch + New
      switch (userLevel)
      {
        case "Sanctum":
          ALevel sanctum = new Sanctum();
          sanctum.Load();
          break;

        case "LazarusLabs":
          ALevel lazLabs = new LazarusLabs();
          lazLabs.Load();
          break;

          // More cases for levels as and when
          // they are created get added here. :(
      }
    }
  }
}
