using System;

namespace gaia.topbar
{
    public class TopBar
    {
        public static void Update()
        {
            int currentCursorTop = Console.CursorTop;
            int currentCursorLeft = Console.CursorLeft;
            int topLine = 0;

            Console.SetCursorPosition(0, topLine);

            string barText = "GAIA";
            string barEndText = $"{Player.location.GetDescription()}";
            

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            // Clear line
            int width = Console.WindowWidth;
            Console.Write(new string(' ', width - 1));
            Console.SetCursorPosition(0, topLine);

            Console.Write(barText);

            Console.ResetColor();

            Console.SetCursorPosition(currentCursorLeft, currentCursorTop);
        }
    }
}
