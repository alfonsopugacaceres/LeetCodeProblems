using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.NewFolder
{
    public class LongPressedName
    {
        public bool IsLongPressedName(string name, string typed)
        {
            int i = 0;
            int j = 0;
            char prev = ' ';
            Stack<char> s = new Stack<char>();
            while (i < name.Length)
            {
                prev = name[i];
                while (i < name.Length && name[i] == name[i + 1])
                {
                    s.Push(name[i]);
                    i++;
                }

                while(s.Count > 0 && s.Peek() == typed[j])
                {
                    s.Pop();
                    j++;
                }
                while(prev == typed[j])
                {
                    j++;
                }
                if(s.Count > 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
