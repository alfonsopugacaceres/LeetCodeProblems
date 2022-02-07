using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.PalindromeNumber
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)//negative values cannot be palindromes since the - sign tapes space
                return false;
            else
            {
                string str = x.ToString();//cast to a string
                int start = 0, end = str.Length - 1;//initialize both indexes

                while(end > start)//this eliminates the middle character
                {
                    //++ and -- are both executed at the end of the accessing the integer variable, therefore they increment after evaluating the number in the array
                    if (str[start++] != str[end--])//check that both ends are the same
                        return false;//if they are not return false
                }
                return true;//if the entire while worked, return true, its a palindrome
            }
        }
    }
}
