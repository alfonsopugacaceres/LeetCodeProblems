using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.XPath;

namespace LeetCodeProblems.Problems.AmazonProblems
{
    public class ArrayRankTransformProblem
    {
        public int[] ArrayRankTransform(int[] arr)
        {
            if(arr.Length < 0 || arr.Length > 100000)
            {
                return null;
            }
            else
            {
                int rank = 1;
                int min = int.MinValue;
                int[] sortedArray = new int[arr.Length];
                int[] rankArr = new int[arr.Length];
                Array.Copy(arr, sortedArray, arr.Length);
                Array.Sort(sortedArray);
                IDictionary<int, int> dict = new Dictionary<int, int>();

                for(int i = 0; i < sortedArray.Length; i++)
                {
                    if (!dict.ContainsKey(sortedArray[i]))
                    {
                        dict.Add(sortedArray[i], rank);
                        rank++;
                    }
                }

                for(int i = 0; i < arr.Length; i++)
                {
                    rankArr[i] = dict[arr[i]];
                }

                return rankArr;
            }
        }
    }
}
