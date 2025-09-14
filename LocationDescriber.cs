using System;

namespace gaia.describer
{
    public class Describer
    {
        public static void Describe(Location loc)
        {
            if (loc == Location.StartingBed)
            {
                ConsoleColor originalForeground = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nWhite Room");
                Console.ForegroundColor = originalForeground;
                Console.WriteLine("You're in a fluffy white bed.");
                Console.WriteLine("You can't see too well.");
                Console.WriteLine("You don't know how you got here.");
            }
        }
    }
}
