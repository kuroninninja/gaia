using System;

namespace gaia.prompter
{
    public class Prompter
    {
        public static void Prompt()
        {
            // Update top bar
            TopBar.Update();
            // Set previous location
            Player.previousLocation = Player.location;
            // Ask for input
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\x1b[1m>  \x1b[0m");
            Console.ResetColor();
            // Get input
            string input = Console.ReadLine().ToLower(); // Lowercase for simplicity
            // Variations of commands
            string[] exitStatements = ["quit"];
            string[] moveStatements = ["move", "go", "leave", "get up", "get out"];
            // Check if any of the commands align with the input
            bool startsWithMove = moveStatements.Any(comm => input.StartsWith(comm));

            var parserOutput = Parser.Parse(input);
            
            foreach (Token character in parserOutput)
            {
                Console.WriteLine(character);
            }

            // For each possible command, check if it aligns: if it does, run said command
            if (parserOutput[0] == Token.QuitComm)
            {
                bool answered = false;
                while (!answered)
                {
                    // Set color
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    // Hide cursor
                    Console.CursorVisible = false;
                    Console.WriteLine("\x1b[1mQuit? (y/n)\x1b[0m");
                    Console.ResetColor();
                    // Read key and convert to string
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    var answer = (keyInfo.Key).ToString();
                    if (answer.ToLower() == "y")
                    {
                        // Quit Gaia
                        Console.Clear();
                        Console.CursorVisible = true;
                        Environment.Exit(0);
                    }
                    else if (answer.ToLower() == "n")
                    {
                        // Get current line (since it is below, subtract 1 to get true)
                        int currentLine = Console.CursorTop - 1;
                        Console.SetCursorPosition(0, currentLine);
                        // Clear question
                        Console.WriteLine(new string(' ', Console.WindowWidth));
                        Console.SetCursorPosition(0, currentLine + 1);
                        // Clear potential error
                        Console.WriteLine(new string(' ', Console.WindowWidth));
                        // Reset cursor
                        Console.SetCursorPosition(0, currentLine);
                        Console.CursorVisible = true;
                        // Exit loop
                        answered = true;
                    }
                    else
                    {
                        // Ditto above
                        int currentLine = Console.CursorTop - 1;
                        // Go to line below question
                        Console.SetCursorPosition(0, currentLine + 1);
                        // Set color to red, show error
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("I couldn't understand that.");
                        // Reset cursor
                        Console.SetCursorPosition(0, currentLine);
                    }
                }
            }
            else if (startsWithMove)
            {
                MoveCommand.FindMoveCase(input);
            }
            
            // Check if player has not moved:
            if (Player.previousLocation == Player.location)
            {
                // if so, don't show description;
                GeneralInfo.showDescription = false;
            }
            else
            {
                // if not, do show descriptpion
                GeneralInfo.showDescription = true;
            }
        }
    }
}
