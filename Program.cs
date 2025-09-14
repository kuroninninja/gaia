using System;

namespace gaia.start
{
    class Program
    {
        public static void Main()
        {
            while (true)
            {
                if (GeneralInfo.showDescription)
                {
                    Describer.Describe(Player.location);
                }
                Prompter.Prompt();
            }
        }
    }
}
