using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Array_Manipulation.FindAllDuplicatesInArray
{
    class FindAllDuplicatesInArray
    {
        /// <summary>
        /// https://www.youtube.com/watch?v=aMsSF1Il3IY
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<int> FindDuplicatesSmallSpace(int[] nums)
        {
            IList<int> ret = new List<int>();//answer array

            //Notice, with the given bounds of the problem we have numbers from [1->n], if we subtract 1 from the number we can get
            //and individual slot in the array. We loop through the numbers and we tag the corresponding index with a *-1
            for (int i = 0; i < nums.Length; i++)//loop through all the numbers
                nums[Math.Abs(nums[i]) - 1] *= -1;//tag all individually recurring numbers with a -1, if it occurs twice the number will be positive

            //loop through all the numbers again, this time checking if the number is positive. If the number at the given index is positive
            //then we know that the index appeared twice in the array, which means we can add it to the list. After adding it to the list we need
            //to remove the tag because we know there is a duplicate index, meaning we would add the same answer twice to the array
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[Math.Abs(nums[i]) - 1] > 0)//check for potiive values at the given index
                {
                    ret.Add(Math.Abs(nums[i]));//if the number at the index was positive, then we know the index number is duplicated so we add it to the list
                    nums[Math.Abs(nums[i]) - 1] *= -1;//get rid of the tag at the index so we do not double count
                }

            }

            return ret;//return the answer

        }
    }
}
