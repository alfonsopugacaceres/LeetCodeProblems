using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.GoogleRecommended
{
    public class SpecialArrayReversal
    {
        public string SpecialArrReversal(string str)
        {
            string ret = string.Empty;
            Stack<char> s = new Stack<char>();
            foreach (char i in str)
            {
                if ((i >= 65 && i <= 90) || (i >= 97 && i <= 122))//valid char
                {
                    s.Push(i);
                }
            }

            foreach (char i in str)
            {
                if ((i >= 65 && i <= 90) || (i >= 97 && i <= 122))//valid char
                {
                    ret += s.Pop();
                }
                else
                {
                    ret += i;
                }
            }

            return ret;
        }
        public string SpecialArrReversalV2(string str)
        {
            string ret = string.Empty;
            int i = 0;
            int j = str.Length - 1;

            while(i < str.Length)
            {

                if (!((i >= 65 && i <= 90) || (i >= 97 && i <= 122)))//valid char
                {

                }
                else if (!((i >= 65 && i <= 90) || (i >= 97 && i <= 122)))
                {

                }
                else
                {

                }
            }

            return ret;
        }
    }
}
