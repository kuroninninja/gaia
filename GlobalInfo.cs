using System;

namespace gaia.info
{
    public static class Player
    {
        public static List<string> inventory = [];
        public static Location location = Location.StartingBed;
        public static Location previousLocation = Location.Placeholder;
    }

    public static class GeneralInfo
    {
        public static ConsoleColor originalColor = Console.ForegroundColor;
        public static bool showDescription = true;
    }
}
