using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.LetterCombinationPhoneNumber
{
    public class LetterCombinationPhoneNumber
    {
        IDictionary<char, IList<string>> numberToLetters = new Dictionary<char, IList<string>>();

        public LetterCombinationPhoneNumber()
        {
            //the scope of this problem is very bounded, we can do the dirty work on the constructor
            numberToLetters.Add('2', new List<string>() { "a", "b", "c" });
            numberToLetters.Add('3', new List<string>() { "d", "e", "f" });
            numberToLetters.Add('4', new List<string>() { "g", "h", "i" });
            numberToLetters.Add('5', new List<string>() { "j", "k", "l" });
            numberToLetters.Add('6', new List<string>() { "m", "n", "o" });
            numberToLetters.Add('7', new List<string>() { "p", "q", "r", "s" });
            numberToLetters.Add('6', new List<string>() { "t", "u", "v" });
            numberToLetters.Add('9', new List<string>() { "w", "x", "y", "z"});
        }
        public IList<string> LetterCombinations(string digits)
        {
            IList<string> res = new List<string>();

            for(int i = 0; i < digits.Length; i++)
            {
                if (numberToLetters.ContainsKey(digits[i]))//check if the digit is in our dictionary
                {
                    IList<string> possibilities = numberToLetters[digits[i]];//get the possibilities
                    if(i == 0)//in the first case we only add the individual letters to the answer
                    {
                        for (int j = 0; j < possibilities.Count; j++)
                            res.Add(possibilities[j]);
                    }
                    else
                    {
                        IList<string> temp = new List<string>();//on the general case we have to create a permutation of possibilities, hence the double loop
                        foreach(string s in res)
                        {
                            for (int j = 0; j < possibilities.Count; j++)
                                temp.Add(s + possibilities[j]);
                        }
                        res = temp;
                    }
                }
            }
            return res;//return the answer

        }
    }
}
