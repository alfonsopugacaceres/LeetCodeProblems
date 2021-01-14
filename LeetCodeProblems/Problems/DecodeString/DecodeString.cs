using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.DecodeString
{
    public class DecodeString
    {
        public string DecodeStr(string s)
        {
            Stack<char> stak = new Stack<char>();
            string decodedString = string.Empty;

            for(int i = 0; i < s.Length; i++)//loop through all letters on the string
            {
                if (s[i] == ']')//if we find the closing bracket indicating decoding begin
                {
                    string temp = string.Empty;//temporary storage
                    while(stak.Count > 0 && stak.Peek() != '['){//while we don't find the opening bracket
                        temp += stak.Pop();//add to the temporary storage
                    }

                    stak.Pop();//remove the leftover '['

                    int times = 0;
                    int mult10 = 1;

                    while (stak.Count > 0 && Char.IsDigit(stak.Peek()))//while we find numbers to multiply the string with
                    {
                        times += (stak.Pop() - '0') * mult10;//converting a digit to an integer directly does not work. This is a shortcut.
                        mult10 = mult10 * 10;//adjust the number multiplier so we can accurately add the next number
                    }

                    //in this section of the code, we take the currently decoded string and we push it into the stack 
                    //so we can progagate multiple operations 
                    while (times > 0)
                    {
                        for (int j = temp.Length - 1; j >= 0; j--)
                        {
                            stak.Push(temp[j]);
                        }
                        times--;
                    }


                }
                else
                {
                    //push the current character into the stack
                    stak.Push(s[i]);
                }
            }

            //prepare return variable
            while(stak.Count > 0)
            {
                decodedString = stak.Pop() + decodedString;
            }


            return decodedString;
        }
    }
}
