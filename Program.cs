using System;

namespace gaia.start
{
    class Program
    {
        public static void Main()
        {
            ConsoleColor originalForeground = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nWhite Room");
            Console.ForegroundColor = originalForeground;
            Console.WriteLine("You're in a fluffy white bed.");
            Console.WriteLine("You can't see too well.");
            Console.WriteLine("You don't know how you got here.");
            while (true)
            {
                Prompter.Prompt();
            }
        }
    }
}
