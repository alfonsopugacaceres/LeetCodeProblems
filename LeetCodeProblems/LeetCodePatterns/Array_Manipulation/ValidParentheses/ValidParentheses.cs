using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Array_Manipulation.ValidParentheses
{
    class ValidParentheses
    {
        //20. Valid Parentheses

        //Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
        //An input string is valid if:
        //Open brackets must be closed by the same type of brackets.
        //Open brackets must be closed in the correct order.

        /// <summary>
        /// Use a stack to manipulate character values and traverse the string to determine if you have
        /// a valid parentheses string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsValid(string s)
        {

            Stack<char> st = new Stack<char>();//create a stack

            foreach (char c in s)//loop through the characters in the string
            {
                if (c == '{' || c == '[' || c == '(')//if its an opening parentheses char
                    st.Push(c);//push onto the stack
                else
                {
                    if (st.Count != 0 &&//if you cannot pop and
                       ((c == ')' && st.Peek() == '(') ||//the current char is ) and the top is (
                       (c == ']' && st.Peek() == '[') ||//OR current char is ] and the top is [
                       (c == '}' && st.Peek() == '{'))//OR current char is { and the top is }
                      )
                        st.Pop();//pop and keep going
                    else
                        return false;//otherwise you got a mismatch, return false
                }
            }
            if (st.Count > 0)//if there are any leftovers you know there was a mismatch
                return false;//return false
            else
                return true;//otherwise all cases got taken care of, return true
        }
    }
}
