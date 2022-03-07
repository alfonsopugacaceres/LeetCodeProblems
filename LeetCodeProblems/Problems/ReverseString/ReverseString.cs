using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.ReverseString
{
    public class ReverseString
    {
        public void ReverseString1(char[] s)
        {
            for (int i = 0, j = s.Length - 1; i < j; j--, i++)//use converging pointers to swap the letters
            {
                char temp = s[i];
                s[i] = s[j];
                s[j] = temp;
            }
        }
    }
}
