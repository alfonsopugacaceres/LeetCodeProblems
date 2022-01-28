using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.Sqrt
{
    public class Sqrt
    {
        public int MySqrt(int x)
        {
            double ret = Math.Floor(Math.Sqrt(x));
            Console.WriteLine(ret);
            return Convert.ToInt32(ret);
        }
    }
}
