using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Array_Manipulation.KClosestPointsToOrigin
{
    class KClosestPointsToOrigin
    {
        //973. K Closest Points to Origin

        //Given an array of points where points[i] = [xi, yi] represents a point on the X-Y plane and an integer k, return the k closest points to the origin(0, 0).
        //The distance between two points on the X-Y plane is the Euclidean distance(i.e., √(x1 - x2)2 + (y1 - y2)2).
        //You may return the answer in any order.The answer is guaranteed to be unique (except for the order that it is in).

        public int[][] KClosest(int[][] points, int k)
        {
            IDictionary<int, IList<int[]>> memo = new Dictionary<int, IList<int[]>>();
            int[] res = new int[points.Length];
            int[][] ret = new int[k][];
            for (int i = 0; i < k; i++)
                ret[i] = new int[2];

            for(int i = 0; i < points.Length; i++)
            {
                res[i] = Convert.ToInt32(Math.Pow((double)points[i][0],2) + Math.Pow((double)points[i][1],2));
                if (!memo.ContainsKey(res[i]))
                    memo.Add(res[i], new List<int[]>() { new int[] { points[i][0], points[i][1] } });
                else
                    memo[res[i]].Add(new int[] { points[i][0], points[i][1] });
            }

            Array.Sort(res);
            int counter = 0;

            while(counter < k)
            {
                IList<int[]> current = memo[res[counter]];

                foreach(int[] coordinate in current)
                {
                    ret[counter][0] = coordinate[0];
                    ret[counter][1] = coordinate[1];
                    counter++;
                }
            }

            return ret;
        }

        public int[][] KClosest1(int[][] points, int K)
        {
            if (points == null || points.Length == 0)
                return new int[][] { };

            return points.OrderBy(x => Math.Pow(x[0], 2) + Math.Pow(x[1], 2)).Take(K).ToArray();
        }


        /// <summary>
        /// using a sorted list
        /// </summary>
        /// <param name="points"></param>
        /// <param name="K"></param>
        /// <returns></returns>
        public int[][] KClosest2(int[][] points, int K)
        {
            var sortedList = new SortedList<double, List<int[]>>();
            foreach (var point in points)
            {
                var distance = GetEuclideanDistance(point);
                if (sortedList.ContainsKey(distance))
                    sortedList[distance].Add(point);
                else
                    sortedList.Add(distance, new List<int[]> { point });
            }

            var result = new int[K][];
            var sortedValues = sortedList.Values;
            for (int i = 0; i < K; i++)
            {
                if (sortedValues[i].Count == 1)
                    result[i] = sortedValues[i][0];
                else
                {
                    foreach (var p in sortedValues[i])
                    {
                        result[i] = p;
                        i++;
                    }
                }
            }
            return result;
        }

        //calulate distance to origin
        //dist((x, y), (a, b)) = √(x - a)² + (y - b)²
        private double GetEuclideanDistance(int[] a)
        {
            var d = (a[0] * a[0]) + (a[1] * a[1]);
            return d;
        }

    }
}
