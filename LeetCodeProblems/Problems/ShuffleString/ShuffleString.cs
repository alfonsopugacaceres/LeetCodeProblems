using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.ShuffleString
{
    public class ShuffleString
    {
        //1528. Shuffle String
        public string RestoreString(string s, int[] indices)
        {
            if (s.Length != indices.Length || s.Length < 0 || s.Length > 100)//check for edge cases
                return string.Empty;
            else
            {
                char[] ret = new char[s.Length];//make a temporary variable to store the shifted characters
                for (int i = 0; i < indices.Length; i++)
                {
                    ret[indices[i]] = s[i];//assign shifted characters
                }
                return new string(ret);//return new string

            }
        }
        public string RestoreString2(string s, int[] indices)
        {
            if (s.Length != indices.Length || s.Length < 0 || s.Length > 100)//check for edge cases
                return string.Empty;
            else
            {
                char[] ret = new char[s.Length];//make a temporary variable to store the shifted characters
                for (int i = 0; i < indices.Length; i++)
                    ret[indices[i]] = s[i];

                return new string(ret);//return new string

            }
        }
    }
}
