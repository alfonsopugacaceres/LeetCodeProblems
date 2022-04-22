//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace LeetCodeProblems.Problems.ConcatenationOfArray
//{
//    public class ConcatenationOfArray
//    {
//        /// <summary>
//        /// This problem is O(n) because we did one pass for computational complexity, for space complexity we have O(2n) since we create an array thats twice the size,
//        /// HOWEVER, we can reduce the complexity of O(2n) -> (n)
//        /// </summary>
//        /// <param name="nums"></param>
//        /// <returns></returns>
//        public int[] GetConcatenation(int[] nums)
//        {

//            if (nums == null || nums.Length < 1 || nums.Length > 1000)//check for the edge cases
//                return null;
//            else
//            {
//                int[] ret = new int[nums.Length * 2];//create the array thats 2*n
//                for (int i = 0; i < nums.Length; i++)//loop through the members of the input array
//                    ret[i] = ret[i + nums.Length] = nums[i];//set ret[i] and ret[i+nums.Length] to nums[i], notice that we are not subtracting one from the length

//                return ret;//return the array
//            }

//            Dictionary<int, int> d = new Dictionary<int, int>();
//            d.Add(1, 1);
//            d.ContainsKey
//        }

//        public int[] GetConcatenation2(int[] nums)
//        {
//            int n = nums.Length;
//            int[] arr = new int[2 * n];
//            Array.Copy(nums, arr, n);
//            Array.Copy(nums, 0, arr, n, n);
//            return arr;
//        }
//        public int[] GetConcatenation3(int[] nums)
//        {
//            if (nums.Length < 1 || nums.Length > 1000)
//                return null;
//            else
//            {
//                int[] result = new int[2 * nums.Length];
//                for (int i = 0, j = 0; i < result.Length; i++, j++)
//                {
//                    if (j == nums.Length) j = 0;
//                    result[i] = nums[j];
//                }

//                return result;
//            }
//        }
//        public int[] GetConcatenation4(int[] nums)
//        {
//            if (nums.Length < 1 || nums.Length > 1000)
//                return null;
//            else
//            {
//                int[] result = new int[nums.Length * 2];
//                for (int i = 0; i < nums.Length; i++)
//                    result[i + nums.Length] = result[i] = nums[i];
//                return result;
//            }
//        }


//    }
//}
