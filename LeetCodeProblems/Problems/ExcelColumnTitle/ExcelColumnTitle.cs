using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.ExcelColumnTitle
{
    public class ExcelColumnTitle
    {
        public string ConvertToTitle(int columnNumber)
        {
            Dictionary<int, char> dict = new Dictionary<int, char>();
            int charInt = 97; 
            for(int i = 1; i <= 26; i++)
            {
                dict.Add(i, (char)charInt);
                charInt++;
            }

            string ret = string.Empty;
            int tempNum = columnNumber;
            while(tempNum > 26)
            {

            }

        }
    }
}
