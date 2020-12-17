using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.TimeToInformEmployees
{
    public class TimeToInformEmployees
    {
        public int NumOfMinutes(int n, int headID, int[] manager, int[] informTime)
        {

            IDictionary<int, IList<int>> managersOf = new Dictionary<int, IList<int>>();

            //create a dictionary that contains a list of people whom the managers manage
            //Example:
            //Manager 0 manages  1, 2, 3, therefore at slot 0 we have a list of employees 1, 2, 3
            //This will allow us to make a depth first search with a recursive function
            for(int i = 0; i < manager.Length; i++)
            {
                if (managersOf.ContainsKey(manager[i]))
                {
                    managersOf[manager[i]].Add(i);
                }
                else
                {
                    managersOf[manager[i]] = new List<int>() { i };
                }
            }

            int sum = Traverse(managersOf, headID, informTime, 0);

            return sum;


        }

        //Using the previously created dictionary, we create a maximum variable, this variable will contain 
        //the maximum amount of time it took to message the employee at the very bottom of the chain.
        //The reason why its not just a simple sum is because some trees will alst longer and only the longest tree is
        //will have the answer since all others will have finished
        public int Traverse(IDictionary<int, IList<int>> dict, int head, int[] informTime, int cur)
        {
            int max = int.MinValue;//create a maximum value

            if (dict.ContainsKey(head))//determine if you have a leaf or if you have a tree
            {
                foreach(int slot in dict[head])//if we have a tree, launch a secondry search for each node in the tree level
                {
                    max = Math.Max(max, Traverse(dict, slot, informTime, cur + informTime[head]));//take the maximum answer for the child trees, once again we only care about the longest answer
                }
                return max;
            }
            else
            {
                return Math.Max(max, cur);//if its a leaf, then there is 0 time to take to inform its children, then we just add the current count that
                                          //took to messate the employee and we begin returning out of the function, at the very end we will have the longest time
            }
        }
    }
}
