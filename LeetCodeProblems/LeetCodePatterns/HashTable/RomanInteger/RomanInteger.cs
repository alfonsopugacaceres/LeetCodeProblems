using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.RomanInteger
{
    //13. Roman to Integer
    public class RomanInteger
    {
        //13. Roman to Integer

        //Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
        //Symbol Value
        //I             1
        //V             5
        //X             10
        //L             50
        //C             100
        //D             500
        //M             1000
        //For example, 2 is written as II in Roman numeral, just two one's added together. 
        //12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.
        //Roman numerals are usually written largest to smallest from left to right.
        //However, the numeral for four is not IIII. Instead, the number four is written as IV.
        //Because the one is before the five we subtract it making four. The same principle 
        //applies to the number nine, which is written as IX.There are six instances where subtraction is used:
        //I can be placed before V (5) and X(10) to make 4 and 9. 
        //X can be placed before L(50) and C(100) to make 40 and 90. 
        //C can be placed before D(500) and M(1000) to make 400 and 900.
        //Given a roman numeral, convert it to an integer.

        public int RomanToInt(string s)
        {
            Dictionary<char, int> romanNums = new Dictionary<char, int>();//create a dictionary with all the values needed for the problem
            romanNums.Add('I', 1);
            romanNums.Add('V', 5);
            romanNums.Add('X', 10);
            romanNums.Add('L', 50);
            romanNums.Add('C', 100);
            romanNums.Add('D', 500);
            romanNums.Add('M', 1000);

            int answer = 0;
            for (int i = 0; i < s.Length; i++)//loop through the entire string
            {
                int currentNumber = romanNums[s[i]];//get the current value
                if (i + 1 == s.Length)//if there is no next value, just add it to the answer
                    answer += currentNumber;
                else
                {
                    int nextNumber = romanNums[s[i + 1]];//otherwise, check the next value
                    if (currentNumber >= nextNumber)//if the current value is greater than or equal to the next value then just add it to the answer
                        answer += currentNumber;
                    else
                    {
                        answer += nextNumber - currentNumber;//otherwise, take the next number and subtract it from the current one, finally add it to the answer
                        i++;
                    }
                }
            }
            return answer;//return the answer

        }

    }
}
