using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.LeetCodePatterns.Array_Manipulation.SortingTheSentence
{
    //1859. Sorting the Sentence

    //A sentence is a list of words that are separated by a single space with 
    //no leading or trailing spaces.Each word consists of lowercase and uppercase English letters.
    //A sentence can be shuffled by appending the 1-indexed word position to each word then rearranging the words in the sentence.
    //For example, the sentence "This is a sentence" can be shuffled as "sentence4 a3 is2 This1" or "is2 sentence4 This1 a3".
    //Given a shuffled sentence s containing no more than 9 words, reconstruct and return the original sentence.
    class SortingTheSentence
    {
        public string SortSentence(string s)
        {
            //create a string builder
            StringBuilder sb = new StringBuilder();
            //use linq to split the string by spaces, then order it by the last character of the word
            IList<string> words = s.Split(" ").OrderBy(f => f[f.Length - 1]).ToList();
            //loop through each one of the words, add each word -1 character to remove the number, add a space
            foreach (string word in words)
            {
                sb.Append(word.Substring(0, word.Length - 1));
                sb.Append(" ");
            }
            //remove the xtra space
            sb.Remove(sb.Length - 1, 1);
            //return the string builder as a string
            return sb.ToString();

        }
    }
}
