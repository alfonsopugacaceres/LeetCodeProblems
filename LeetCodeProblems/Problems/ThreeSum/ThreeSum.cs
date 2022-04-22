//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace LeetCodeProblems.Problems.ThreeSum
//{
//    public class ThreeSum
//    {
//        public IList<IList<int>> ThreeSu(int[] nums)
//        {
//            IList<IList<int>> res = new List<IList<int>>();
//            IDictionary<int, IList<(int,int)>> complements = new Dictionary<int, IList<(int, int)>>();
//            HashSet<int> possibleks = new HashSet<int>();

//            for(int i = 0; i < nums.Length; i++)
//            {
//                if (!possibleks.Contains(nums[i]))
//                    possibleks.Add(nums[i]);
//                for(int j = 1; j < nums.Length; j++)
//                {
//                    if(nums[i] != nums[j])
//                    {
//                        if (complements.ContainsKey(nums[i] + nums[j]))
//                            complements[nums[i] + nums[j]].Add(i);
//                        else
//                        {
//                            (int, int) tuple = (i, j);
//                            complements.Add(nums[i] + nums[j], new List<(int, int)>(){tuple});
//                        }
//                    }
//                }
//            }

//            foreach(KeyValuePair<int, IList<(int, int)>> keypair in complements)
//            {
//                if (possibleks.Contains(keypair.Key))
//                {
//                    foreach (var val in keypair.Value)
//                    {
//                        if (val.Item1 != keypair.Key && val.Item2 != keypair.Key)
//                        {
//                            res.Add(new List<int>() { val.Item1, val.Item1, keypair.Key });
//                        }
//                    }
//                }
//            }

//            return res;
//        }

        
//    }
//}
