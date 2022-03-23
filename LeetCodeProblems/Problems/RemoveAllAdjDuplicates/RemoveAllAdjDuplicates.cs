using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.RemoveAllAdjDuplicates
{
    public class RemoveAllAdjDuplicates
    {

        //1047. Remove All Adjacent Duplicates In String
        public string RemoveDuplicates(string s)
        {
            StringBuilder sb = new StringBuilder();


            for (int i = 0; i < s.Length; i++)
            {
                if (sb.Length > 0 && sb[sb.Length - 1] == s[i])
                {
                    sb.Remove(sb.Length - 1, 1);
                }
                else
                {
                    sb.Append(s[i]);
                }
            }

            return sb.ToString();
        }
    }
}
