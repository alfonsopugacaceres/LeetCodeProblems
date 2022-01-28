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
            if (arr.Length < 1 || arr.Length > 1000)//edge cases
                return -1;

            Array.Sort(arr);//sort the array by weight
            int sum = 0;//running tally
            int limit = 5000;//weight limit
            int i = 0;
            for (i = 0; i < arr.Length; i++)//loop through the array
            {
                if (arr[i] < 1 || arr[i] > 1000)//edge cases
                    return -1;
                else
                {
                    sum += arr[i];//add the current weight to the tally
                    if (sum > limit)//break out if we go over the limit
                    {
                        break;
                    }
                }
            }

            return i;
        }
    }
}
