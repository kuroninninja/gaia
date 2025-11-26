using System;
using System.Collections.Generic;
using gaia.tokenizer;

namespace gaia.parser
{
    public class Parser
    {
        public static List<Token> Parse(string userInput)
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
            string[] noPunct = afterPunct.Split(' ');
            List<string> textList = noPunct.ToList();

            // Filler (unnecessary) words
            string[] fillerWords = ["the", "a", "an"];

            // Loop through each word and remove fillers
            for(int i = textList.Count - 1; i >= 0; i--)
            {
                if (fillerWords.Contains(textList[i]))
                {
                    textList.RemoveAt(i);
                } 
            }

            return Tokenizer.Tokenize(textList);
        }
    }
}
