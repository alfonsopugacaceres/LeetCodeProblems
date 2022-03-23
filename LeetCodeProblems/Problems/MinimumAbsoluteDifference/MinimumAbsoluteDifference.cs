using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.MinimumAbsoluteDifference
{
    public class MinimumAbsoluteDifference
    {
        public IList<IList<int>> MinimumAbsDifference(int[] arr)
        {

            if (arr.Length < 2 || arr.Length > 100000)
                return null;
            else
            {
                Array.Sort(arr);
                IList<IList<int>> ret = new List<IList<int>>();
                int min = int.MaxValue;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    int diff = Math.Abs(arr[i] - arr[i + 1]);
                    if (min > diff)
                    {
                        ret.Clear();
                        min = diff;
                        ret.Add(new List<int>() { arr[i], arr[i + 1] });
                    }
                    else if (min == diff)
                    {
                        ret.Add(new List<int>() { arr[i], arr[i + 1] });
                    }
                }
                return ret;
            }

        }
    }
}
