using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.LeetCodePatterns.Backtracking.GenerateParentheses
{
    public class GenerateParentheses
    {
        public IList<string> GenerateParenthesis1(int n)
        {
            IList<string> res = new List<string>();
            GenerateParenthesisBacktracking(0, 0, n, new Stack<string>(), res);
            return res;
        }

        public void GenerateParenthesisBacktracking(int opening, int closing, int n, Stack<string> st, IList<string> res)
        {
            if (opening == n && closing == n)
            {
                StringBuilder sb = new StringBuilder();
                IList<string> temp = st.ToList();
                for (int i = temp.Count - 1; i >= 0; i--)
                    sb.Append(temp[i]);

                res.Add(sb.ToString());
            }
            if (opening < n)
            {
                st.Push("(");
                GenerateParenthesisBacktracking(opening + 1, closing, n, st, res);
                st.Pop();
            }
            if (opening > 0 && closing < opening)
            {
                st.Push(")");
                GenerateParenthesisBacktracking(opening, closing + 1, n, st, res);
                st.Pop();
            }
        }
    }
}
