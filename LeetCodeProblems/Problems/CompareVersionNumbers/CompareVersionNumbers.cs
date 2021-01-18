using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.CompareVersionNumbers
{
    public class CompareVersionNumbers
    {
        public int CompareVersion(string version1, string version2)
        {
            string[] v1split = version1.Split('.');
            string[] v2split = version2.Split('.');
            string[] larger = null;
            string[] smaller = null;
            bool v2Larger = false;


            if (v1split.Length >= v2split.Length)
            {
                larger = v1split;
                smaller = v2split;
            }
            else
            {
                larger = v2split;
                smaller = v1split;
                v2Larger = true;
            }

            int largerCounter = 0;
            int smallerCounter = 0;


            while (largerCounter < larger.Length)
            {
                int largerNum = Convert.ToInt32(larger[largerCounter]);
                if (smallerCounter < smaller.Length)
                {
                    int smallerNum = Convert.ToInt32(smaller[smallerCounter]);
                    if (largerNum > smallerNum)
                    {
                        return (v2Larger) ? -1 : 1;
                    }
                    else if (largerNum < smallerNum)
                    {
                        return (v2Larger) ? 1 : -1;
                    }

                    smallerCounter++;
                    largerCounter++;
                }
                else
                {
                    if (largerNum == 0)
                    {
                        largerCounter++;
                    }
                    else
                    {
                        return (v2Larger) ? -1 : 1;
                    }
                }
            }

            return 0;
        }
    }
}
