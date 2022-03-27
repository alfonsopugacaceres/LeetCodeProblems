using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Array_Manipulation.LetterCasePermutation
{
    class LetterCasePermutation
    {


        //784. Letter Case Permutation
        //Given a string s, you can transform every letter individually to be lowercase or uppercase to create another string.
        //Return a list of all possible strings we could create.Return the output in any order.
        public IList<string> LetterCasePermutation1(string s)
        {

            List<string> ret = new List<string>();


            for (int target = 0; target < s.Length; target++)//iterate through the string
            {
                char c = s[target];//get the target character

                if (ret.Count == 0)//if its the first character
                {
                    if (Char.IsDigit(c))//if its a digit add it once
                        ret.Add(c.ToString());
                    else
                    {
                        ret.Add(char.ToUpper(c).ToString());//otherwise we add it twice, once as an upper once as a lower case letter
                        ret.Add(char.ToLower(c).ToString());
                    }
                }
                else//otherwise, if we are adding any character but the first character
                {
                    if (!Char.IsDigit(c))//if its not a digit
                    {
                        List<string> upperAdd = new List<string>();//create a temporary storage for propagating strings, in this case upper strings
                        for (int i = 0; i < ret.Count; i++)//loop through our current result set
                        {
                            StringBuilder sb = new StringBuilder(ret[i]);//get a string builder at the target string
                            sb.Append(Char.ToLower(c));//append the lowercase character
                            ret[i] = sb.ToString();//set the current string to the string builder plus the appended lower case
                            sb[sb.Length - 1] = (Char.ToUpper(c));//replace the string builder last character with an upper case of the same letter
                            upperAdd.Add(sb.ToString());//add it to the upper list (note, we dont want to modify our current list because we'd get stuck in a loop)
                        }

                        ret.AddRange(upperAdd);//merge the two lists
                    }
                    else//otherwise if its a digit
                    {
                        for (int i = 0; i < ret.Count; i++)//go through all the string on the list and just append the digit
                            ret[i] = ret[i] + c;
                    }
                }
            }

            return ret;//return the answer
        }
    }
}
