using System;
using MoveComm.Destinations;

namespace Commands.Move
{
    public static class MoveCommand
    {
        public static void FindMoveCase(string userCommand)
        {
            // Depending on the player location, call a different function
            // which itself uses the userCommand argument to determine
            // destination and behavior.

            // Depending on location, call different function
            if (Player.location == Location.StartingBed)
            {
                ParseMoveComm.StartingBed(userCommand);
            }
        }
    }
}
