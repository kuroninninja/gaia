using System;

namespace MoveComm.Destinations
{
    public class ParseMoveComm
    {
        public static void StartingBed(string userCommand)
        {
            string[] splitCommand = userCommand.Split(' ');
            foreach (string token in splitCommand)
            {
                Console.WriteLine(token);
            }
        }
    }
}
