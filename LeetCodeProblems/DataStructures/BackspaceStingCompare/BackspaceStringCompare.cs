using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.GoogleRecommended.GooglePatterns.BackspaceStingCompare
{
    public class BackspaceStringCompare
    {
        //844. Backspace String Compare
        //Given two strings s and t, return true if they are equal when both are typed into empty text editors. '#' means a backspace character.
        //Note that after backspacing an empty text, the text will continue empty.

        public bool BackspaceCompare(string s, string t)
        {
            Stack<char> S = new Stack<char>();
            Stack<char> T = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '#' && S.Count > 0)
                    S.Pop();
                if (s[i] != '#')
                    S.Push(s[i]);
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == '#' && T.Count > 0)
                    T.Pop();
                if (t[i] != '#')
                    T.Push(t[i]);
            }

            if (S.Count != T.Count)
                return false;

            while (S.Count > 0)
            {
                if (T.Pop() != S.Pop())
                    return false;
            }
            return true;

        }
        //public bool BackspaceCompare(string s, string t)
        //{
        //    StringBuilder sFinal = new StringBuilder();

        //    for(int i = 0; i < s.Length; i++)
        //    {
        //        if(s[i] != '#')

        //    }

        //}
    }
}
