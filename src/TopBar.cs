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
            int width = Console.WindowWidth;

            Console.SetCursorPosition(0, topLine);

            string barText = "GAIA";
            string barEndText = $"{Player.location.GetDescription()}";
            string barMiddleText = new string(' ', width - (barText.Length + barEndText.Length));
            
            barText = barText + barMiddleText + barEndText;
            

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            // Clear line
            Console.Write(new string(' ', width - 1));
            Console.SetCursorPosition(0, topLine);

            Console.Write(barText);

            Console.ResetColor();

            Console.SetCursorPosition(currentCursorLeft, currentCursorTop);
        }
    }
}
