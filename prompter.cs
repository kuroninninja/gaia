using System;

namespace gaia.prompter
{
   public class Prompter
   {
       public static void Prompt()
       {
           Console.Write(">  ");
           string input = Console.ReadLine().ToLower();
           string[] exitStatements = ["quit"];
           if (exitStatements.Contains(input))
           {
               Environment.Exit(0);
           }
       }
   }
}
