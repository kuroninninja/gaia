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
                    Console.Write("Quit? (y/n)  ");
                    string answer = Console.ReadLine();
                    if (answer.ToLower() == "y")
                    {
                        Console.Clear();
                        Environment.Exit(0);
                    }
                    else if (answer.ToLower() == "n")
                    {
                        answered = true;
                    }
                    else
                    {
                        Console.WriteLine("I couldn't understand that.");
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
