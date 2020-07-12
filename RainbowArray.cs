using System;
namespace Swizilla
{
    class RainbowArray
    {
        static void Main(string[] args)
        {
            // Define an array which contains color positions.
            string[] rainbowColors = { "unknown", "Red", "Orange", "Yellow",
                                        "Green", "Blue", "Indigo", "Violet" };

            Console.Write("Mention position(1 to 7) in the Rainbow to get the color: ");

            // Variable to hold the position provided by user.
            int position = Convert.ToInt32(Console.ReadLine().Trim());

            // Variable to hold the name of Color provided position.
            string color;

            // Sanity check to verify if position is between 1 to 7.
            if (1 > position || rainbowColors.Length - 1 < position)
                // If its not, then simply set colors as unknown,
                // i.e. element at zeroth-offset in rainbowColors.
                color = rainbowColors[0];
            else
                // Else get color at position-offset from the
                // rainbowColors array.
                color = rainbowColors[position];

            // Displaying which color was at provided position.
            Console.WriteLine($"Color at {position} is: {color}");
        }
    }
}
