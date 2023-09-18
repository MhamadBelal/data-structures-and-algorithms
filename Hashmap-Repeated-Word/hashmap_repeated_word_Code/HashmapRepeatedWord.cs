using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashmap_repeated_word_Code
{
    public class HashmapRepeatedWord
    {
        public static string RepeatedWord(string inputString)
        {
            // Step 1: Split the input string into words
            string[] words = inputString.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            // Step 2: Create a HashSet to track seen words
            HashSet<string> seenWords = new HashSet<string>(StringComparer.OrdinalIgnoreCase); // Ignore case

            // Step 3: Iterate through the words
            foreach (string word in words)
            {
                // Step 3a: Check if the word is already in the HashSet
                if (seenWords.Contains(word))
                {
                    return word; // Step 3b: Return the repeated word
                }
                // Step 3c: Add the word to the HashSet
                seenWords.Add(word);
            }

            // Step 4: If no repeated word is found, return null or a message
            return null;
        }
    }
}