using System;

namespace gaia.prompter
{
    public class Prompter
    {
        public static void Prompt()
        {
            // Set previous location
            Player.previousLocation = Player.location;
            // Ask for input
            Console.Write(">  ");
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
            if (exitStatements.Contains(input))
            {
                Environment.Exit(0);
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
