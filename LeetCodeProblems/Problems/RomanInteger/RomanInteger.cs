using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.RomanInteger
{
    //13. Roman to Integer
    public class RomanInteger
    {
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
