using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.Problems.DivideArraySetKNumbers
{
    public class DivideArraySetKNumbers
    {
        public bool IsPossibleDivide(int[] nums, int k)
        {

            if (k <= 0)
            {
                return false;
            }
            else if (nums.Length % k > 0)
            {
                return false;
            }
            else
            {

                //create a sorted dictionary
                SortedList<int, int> valOcurrece = new SortedList<int, int>();
                Stack<int> st = new Stack<int>();

                //populate the dictionary
                for (int i = 0; i < nums.Length; i++)
                {
                    if (!valOcurrece.ContainsKey(nums[i]))
                    {
                        valOcurrece[nums[i]] = 1;
                    }
                    else
                    {
                        valOcurrece[nums[i]] += 1;
                    }
                }

                //total count is used to determine if we are done
                int totalcount = 0;
                IList<int> keys = valOcurrece.Keys.ToList();
                //index is used to keep track of the current item on the keys list
                int index = 0;

                //while we haven't mapped all elements
                while (totalcount < nums.Length)
                {
                    //curcount keeps track of how many we have on the current set
                    int curCount = 0;

                    int key = keys[index];
                    if (valOcurrece[key] <= 0)
                    {
                        index++;
                        continue;
                    }
                    else
                    {
                        valOcurrece[key] -= 1;
                        int currentKey = key;
                        totalcount++;
                        curCount++;
                        while (curCount < k)
                        {
                            if (valOcurrece.ContainsKey(currentKey + 1) && valOcurrece[currentKey + 1] > 0)
                            {
                                valOcurrece[currentKey + 1] -= 1;
                                curCount++;
                                currentKey++;
                                totalcount++;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }
                }
                return true;
            }
        }
    }
}
