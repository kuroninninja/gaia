using System;

namespace gaia.describer
{
    public class Describer
    {
        public static void BoldWriteLine(string text)
        {
            Console.WriteLine($"\x1b[1m" + $"{text}" + $"\x1b[0m");
        }
        public static void Describe(Location loc)
        {
            // For each location, uniquely describe it
            if (loc == Location.StartingBed)
            {
                ConsoleColor originalForeground = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Blue;
                BoldWriteLine("\nWhite Room");
                Console.ForegroundColor = originalForeground;
                Console.WriteLine("You're in a fluffy white bed.");
                Console.WriteLine("You can't see too well.");
                Console.WriteLine("You don't know how you got here.");
            }
        }
    }
}
