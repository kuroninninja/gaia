using System;
using System.Collections.Generic;

namespace gaia.parser
{
    public class Parser
    {
        public static List<string> Parse(string userInput)
        {
            // Convert input to array of characters
            char[] inputArray = userInput.ToCharArray();
            List<char> inputLetters = userInput.ToList();
            // Every punctuation mark
            char[] punctuationMarks = [',', '.', ';', ':', '!', '?'];
            // Loop through each and remove punctuation
            for(int i = inputLetters.Count - 1; i >= 0; i--)
            {
                if (punctuationMarks.Contains(inputLetters[i]))
                {
                    inputLetters.RemoveAt(i);
                }
            }
            // Join list back to string
            string afterPunct = string.Join("", inputLetters);
            string[] aPArray = afterPunct.Split(' ');
            List<string> textList = aPArray.ToList();
            return textList;
        }
    }
}
