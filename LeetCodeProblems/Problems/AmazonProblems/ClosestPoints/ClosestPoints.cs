using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LeetCodeProblems.Problems.AmazonProblems.ClosestPoints
{
    public class ClosestPoints
    {
        public int[][] KClosest(int[][] points, int K)
        {
            double placeholder = 0;
            IDictionary<double, IList<int>> dict = new Dictionary<double, IList<int>>();


            if(points.Length < 1 || points.Length > 10000)
            {
                return null;
            }
            else
            {
                for(int i = 0; i < points.Length; i++)
                {
                    placeholder = SimplifiedEucledianDistance(0, 0, points[i][0], points[i][1]);
                    if (dict.ContainsKey(placeholder))
                    {
                        dict[placeholder].Add(i);
                    }
                    else
                    {
                        IList<int> list = new List<int>();
                        list.Add(i);
                        dict.Add(placeholder, list);
                    }
                }
            }

            double [] keys = dict.Keys.ToArray();
            Array.Sort(keys);
            int[][] response = new int[K][];

            for(int i = 0; i < K; i++)
            {
                IList<int> vals = dict[keys[i]];
                if(vals.Count > 1)
                {
                    int j = 0;
                    while(j < vals.Count)
                    {
                        response[i] = points[vals[j]];
                        j++;
                        i++;
                        if (i >= K)
                            break;
                    }
                }
                else
                {
                    response[i] = points[vals[0]];
                }
            }

            return response;
        }

        public double SimplifiedEucledianDistance(int x1, int y1, int x2, int y2)
        {
            return Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2);
        }

        public double EucledianDistance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }
    }
}
