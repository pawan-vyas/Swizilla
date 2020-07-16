using System;
namespace Swizilla
{
    class RainbowSwitch
    {
        static void _Main(string[] args)
        {
            Console.Write("Mention position(1 to 7) in the Rainbow to get the color: ");
            
            // Variable to hold the user entered position.
            int position = Convert.ToInt32(Console.ReadLine().Trim());
            string color;

            // Using switch, check which position was entered,
            // and assign the appropriate value to color.
            switch (position)
            {
                case 1:
                    color = "Red";
                    break;
                case 2:
                    color = "Orange";
                    break;
                case 3:
                    color = "Yellow";
                    break;
                case 4:
                    color = "Green";
                    break;
                case 5:
                    color = "Blue";
                    break;
                case 6:
                    color = "Indigo";
                    break;
                case 7:
                    color = "Violet";
                    break;
                default:
                    color = "unknown";
                    break;
            }

            // Displaying which color was at provided position.
            Console.WriteLine($"Color at {position} is: {color}");
        }
    }
}
