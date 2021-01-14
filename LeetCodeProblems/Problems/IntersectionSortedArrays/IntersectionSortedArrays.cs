using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.IntersectionSortedArrays
{
    public class IntersectionSortedArrays
    {
        public IList<int> ArraysIntersection(int[] arr1, int[] arr2, int[] arr3)
        {
            IList<int> ls = new List<int>();
            IDictionary<int, int> incident = new Dictionary<int, int>();

            int i = 0;
            int j = 0;
            int k = 0;

            while(i < arr1.Length && j < arr2.Length && k < arr3.Length)
            {
                if(i < arr1.Length)
                {
                    if (incident.ContainsKey(arr1[i]))
                    {
                        incident[arr1[i]] += 1;
                        if(incident[arr1[i]] == 3)
                        {
                            ls.Add(arr1[i]);
                        }
                    }
                    else
                    {
                        incident[arr1[i]] = 1;
                    }
                }
                if (j < arr2.Length)
                {
                    if (incident.ContainsKey(arr2[j]))
                    {
                        incident[arr2[j]] += 1;
                        if (incident[arr2[j]] == 3)
                        {
                            ls.Add(arr2[j]);
                        }
                    }
                    else
                    {
                        incident[arr2[j]] = 1;
                    }
                }
                if (k < arr3.Length)
                {
                    if (incident.ContainsKey(arr3[i]))
                    {
                        incident[arr3[k]] += 1;
                        if (incident[arr3[k]] == 3)
                        {
                            ls.Add(arr3[k]);
                        }
                    }
                    else
                    {
                        incident[arr3[k]] = 1;
                    }
                }
                i++;
                j++;
                k++;
            }

            return ls;
        }
    }
}
