using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.SortingSentence
{
    public class SortingSentence
    {
        public string SortSentence(string s)
        {

            if (s.Length < 2 || s.Length > 200)//take care of the edge cases
                return string.Empty;
            else
            {
                string[] words = s.Split(" ");//split the string by spaces
                if (words.Length > 9 || words.Length < 1)//check for other edge cases
                    return string.Empty;
                else
                {
                    StringBuilder sb = new StringBuilder();//use a string builder for efficiency
                    string[] ordered = new string[words.Length];//create an ordered version of the strin garray
                    foreach (string word in words)
                    {
                        int numbering = (int)Char.GetNumericValue(word[word.Length - 1]);//extract the numbering and cast it
                        ordered[numbering - 1] = word.Substring(0, word.Length - 1);//use the numbering to populate the array
                    }

                    foreach (string orderedWord in ordered)//create the ordered sentence adding a space in between
                    {
                        sb.Append(orderedWord);
                        sb.Append(" ");
                    }

                    sb.Remove(sb.Length - 1, 1);//remove the extra space

                    HashSet<char> c = new HashSet<char>();

                    return sb.ToString();
                }
            }
        }
    }
}
