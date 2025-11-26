using System;

namespace gaia.tokenizer
{
    public class Tokenizer
    {
        public static List<Token> Tokenize(List<string> cleanedInput)
        {
            List<Token> output = new List<Token>();
            // Each quit token
            List<string> quitStatements = ["quit"];
            // Each context object (unspecific identifier)
            List<string> contextObjects = ["it", "that", "them"];
            // Each get token
            List<string> getStatements = ["get", "grab", "take"];
            for(int i = 0; i < cleanedInput.Count; i++)
            {
                var item = cleanedInput[i];
                if (quitStatements.Contains(item))
                {
                    output.Add(Token.QuitComm);
                }
                else if (contextObjects.Contains(item))
                {
                    output.Add(Token.ContextObj);
                }
                else if (getStatements.Contains(item))
                {
                    output.Add(Token.GetComm);
                }
                else
                {
                    output.Add(Token.UnknownItem);
                }
            }

            return output;
        }
    }
}
