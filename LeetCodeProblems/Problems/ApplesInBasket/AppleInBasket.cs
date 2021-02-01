using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.ApplesInBasket
{
    //1196. How Many Apples Can You Put into the Basket
    public class AppleInBasket
    {
        public int MaxNumberOfApples(int[] arr)
        {

            Array.Sort(arr);
            int sum = 0;
            int limit = 5000;
            int i = 0;
            for (i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (sum > limit)
                {
                    break;
                }
            }

            return i;
        }
    }
}
