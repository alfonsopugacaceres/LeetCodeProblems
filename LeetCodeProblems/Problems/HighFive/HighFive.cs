using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.HighFive
{
    public class HighFiveP
    {
        //1086. High Five    
        public void MaintainStack(Stack<int> stack, int nval)
        {
            if (stack == null)
            {
                return;
            }
            else
            {
                if (stack.Count == 5)
                {
                    IList<int> temp = new List<int>();
                    while (stack.Count > 0 && stack.Peek() < nval)
                    {
                        temp.Add(stack.Pop());
                    }
                    stack.Push(nval);
                    while (stack.Count < 5 && temp.Count > 0)
                    {
                        stack.Push(temp[0]);
                        temp.RemoveAt(0);
                    }
                }
                else
                {
                    stack.Push(nval);
                }
            }
        }
        public int[][] HighFive(int[][] items)
        {
            IDictionary<int, Stack<int>> stuDict = new SortedList<int, Stack<int>>();

            int id = 0;
            int val = 0;
            for (int i = 0; i < items.Length; i++)
            {
                id = items[i][0];
                val = items[i][1];
                if (stuDict.ContainsKey(id))
                {

                    MaintainStack(stuDict[id], val);
                }
                else
                {
                    stuDict[id] = new Stack<int>();
                    MaintainStack(stuDict[id], val);
                }
            }

            int[][] res = new int[stuDict.Keys.Count][];
            int counter = 0;

            foreach (int key in stuDict.Keys)
            {
                res[counter] = new int[2];
                int avg = 0;
                while(stuDict[key].Count > 0)
                {
                    avg += stuDict[key].Pop();
                }
                res[counter][0] = key;
                res[counter][1] = avg / 5;
            }

            return res;
        }
    }
}
