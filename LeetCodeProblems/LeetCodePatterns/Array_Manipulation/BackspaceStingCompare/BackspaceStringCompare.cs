using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.GoogleRecommended.GooglePatterns.BackspaceStingCompare
{
    public class BackspaceStringCompare
    {
        //tags amazon google microsoft

        //844. Backspace String Compare
        //Given two strings s and t, return true if they are equal when both are typed into empty text editors. '#' means a backspace character.
        //Note that after backspacing an empty text, the text will continue empty.

        /// <summary>
        /// Use two stacks to clean up the strings and then compare them together
        /// </summary>
        /// <param name="s">string input 1</param>
        /// <param name="t">string input 2</param>
        /// <returns></returns>
        public bool BackspaceCompare(string s, string t)
        {
            Stack<char> S = new Stack<char>();//make stack 1
            Stack<char> T = new Stack<char>();//make stack 2

            for (int i = 0; i < s.Length; i++)//traverse the string
            {
                if (s[i] == '#' && S.Count > 0)//if you find a '#' and the stack is not empty, then pop
                    S.Pop();
                if (s[i] != '#')//otherwise push onto the stack
                    S.Push(s[i]);
            }

            for (int i = 0; i < t.Length; i++)//traverse the string
            {
                if (t[i] == '#' && T.Count > 0)//if you find a '#' and the stack is not empty, then pop
                    T.Pop();
                if (t[i] != '#')//otherwise push onto the stack
                    T.Push(t[i]);
            }

            if (S.Count != T.Count)//if the lengths are different you already know the strings are not the same
                return false;

            while (S.Count > 0)//loop through the stacks and double check all characters are the same
            {
                if (T.Pop() != S.Pop())
                    return false;//if the popped characters are not the same, return false
            }
            return true;//if you reach this spot, then you know the strings were the same

        }
    }
}
