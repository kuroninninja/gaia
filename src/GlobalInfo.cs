using System;

namespace gaia.info
{
    public static class Player
    {
        // Inventory
        public static List<string> inventory = [];
        // Location; set default to the starting bed
        public static Location location = Location.StartingBed;
        // Since there is no previous location, set as placeholder
        public static Location previousLocation = Location.Placeholder;
    }

    public static class GeneralInfo
    {
        // Original color for use when changing the foreground color
        public static ConsoleColor originalColor = Console.ForegroundColor;
        // Boolean for determining whether to show description
        public static bool showDescription = true;
    }
}
