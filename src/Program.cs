using System;

namespace gaia.start
{
    class Program
    {
        public static void Main()
        {
            // Repeat forever until exited
            while (true)
            {
                // Check if the player has moved; if so,
                // describe location
                if (GeneralInfo.showDescription)
                {
                    // Show description of current location
                    Describer.Describe(Player.location);
                }
                // Ask for command
                Prompter.Prompt();
            }
        }
    }
}
