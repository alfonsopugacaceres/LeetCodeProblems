using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.Problems.KClosestPoint
{
    public class KClosestPoint
    {
        public int[][] KClosest(int[][] points, int K)
        {
            IDictionary<double, IList<int[]>> dict = new SortedList<double, IList<int[]>>();
            for (int i = 0; i < points.Length; i++)
            {
                double res = Math.Sqrt(Math.Pow(points[i][0], 2) + Math.Pow(points[i][1], 2));
                if (!dict.ContainsKey(res))
                {

                    dict[res] = new List<int[]>();
                }
                dict[res].Add(new int[2] { points[i][0], points[i][1] });
            }



            int resCounter = 0;
            int[][] response = new int[K][];
            IList<int[]> sortedVals = new List<int[]>();
            foreach(var listX in dict)
            {
                foreach(var x in listX.Value)
                {
                    if (resCounter < K)
                    {
                        response[resCounter] = x;
                        resCounter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (resCounter >= K)
                {
                    break;
                }
            }
            return response;
        }

        public int[][] KClosest2(int[][] points, int K)
        {
            double placeholder = 0;
            IDictionary<double, IList<int>> dict = new Dictionary<double, IList<int>>();


            if (points.Length < 1 || points.Length > 10000)
            {
                return null;
            }
            else
            {
                for (int i = 0; i < points.Length; i++)
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

            double[] keys = dict.Keys.ToArray();
            Array.Sort(keys);
            int[][] response = new int[K][];

            for (int i = 0; i < K; i++)
            {
                IList<int> vals = dict[keys[i]];
                if (vals.Count > 1)
                {
                    int j = 0;
                    while (j < vals.Count)
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
    }
}