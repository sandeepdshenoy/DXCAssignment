using ActionProcessor;
using System;
using System.Linq;

namespace SequenceAnalysis
{
    public class SequanceAnalysis : IProcessor
    {
        public bool PerformAction(string Input)
        {
            string[] words = Input.Split(' ');

            // Find uppercase words and concatenate them into a single string
            string uppercaseWords = String.Concat(words.Where(word => word.All(char.IsUpper)));

            // Order the characters in the uppercase words alphabetically
            string sortedUppercaseWords = new string(uppercaseWords.OrderBy(c => c).ToArray());

            // Print the resulting words
            Console.WriteLine(sortedUppercaseWords);
            return true;
        }
    }
}
