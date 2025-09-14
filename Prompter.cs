using System;

namespace gaia.prompter
{
    public class Prompter
    {
        public static void Prompt()
        {
            Player.previousLocation = Player.location;
            Console.Write(">  ");
            string input = Console.ReadLine().ToLower();
            string[] exitStatements = ["quit"];
            string[] moveStatements = ["move", "go", "leave", "get up", "get out"];
            bool startsWithMove = moveStatements.Any(comm => input.StartsWith(comm));
            if (exitStatements.Contains(input))
            {
                Environment.Exit(0);
            }
            else if (startsWithMove)
            {
                MoveCommand.FindMoveCase(input);
            }
            
            if (Player.previousLocation == Player.location)
            {
                GeneralInfo.showDescription = false;
            }
            else
            {
                GeneralInfo.showDescription = true;
            }
        }
    }
}
