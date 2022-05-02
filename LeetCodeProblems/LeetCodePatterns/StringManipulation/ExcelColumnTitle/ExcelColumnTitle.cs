using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.StringManipulation.ExcelColumnTitle
{
    public class ExcelColumnTitle
    {
        //171. Excel Sheet Column Number
        //Given a string columnTitle that represents the column title as appear in an Excel sheet, return its corresponding column number.


        public int TitleToNumber(string columnTitle)
        {
            int result = 0;
            int n = columnTitle.Length;
            for (int i = 0; i < n; i++)
            {
                result = result * 26;
                result += (columnTitle[i] - 'A' + 1);
            }
            return result;
        }
    }
}
