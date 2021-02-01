using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.FixedPoint
{
    public class FixedPoint
    {
        //1064. Fixed Point
        public int FixedP(int[] arr)
        {
            int res = -1;

            for(int i = 0; i < arr.Length; i++)
            {
                if(i == arr[i])
                {
                    return i;
                }
            }
            return res;
        }
    }
}
