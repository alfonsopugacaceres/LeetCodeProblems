using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.Problems.NestedListWeightSum
{
    //339. Nested List Weight Sum
    public interface NestedInteger
    {

        //// Constructor initializes an empty nested list.
        //public NestedInteger();

        //// Constructor initializes a single integer.
        //public NestedInteger(int value);

        // @return true if this NestedInteger holds a single integer, rather than a nested list.
        bool IsInteger();

        // @return the single integer that this NestedInteger holds, if it holds a single integer
        // Return null if this NestedInteger holds a nested list
        int GetInteger();

        // Set this NestedInteger to hold a single integer.
        public void SetInteger(int value);

        // Set this NestedInteger to hold a nested list and adds a nested integer to it.
        public void Add(NestedInteger ni);

        // @return the nested list that this NestedInteger holds, if it holds a nested list
        // Return null if this NestedInteger holds a single integer
        IList<NestedInteger> GetList();
    }

    public class NestedListWeightSum
    {
        
        public int DepthSum(IList<NestedInteger> nestedList)
        {
            return DepthFirstSearch(nestedList, 1);
        }

        public int BreathFirstSearch(IList<NestedInteger> nestedList)
        {
            Queue<NestedInteger> q = new Queue<NestedInteger>();
            nestedList.ToList().ForEach(f => q.Enqueue(f));

            int depth = 1;
            int curSum = 0;

            while(q.Count > 0)//while the queue is not empty
            {
                int curSize = q.Count;//take a snapshot of the queue size BEFORE we process it
                for(int i = 0; i < curSize; i++)//using the snapshot of the size, loop through the queue
                {
                    NestedInteger x = q.Dequeue();//pop the first element of the queue
                    if (x.IsInteger())
                    {
                        curSum += x.GetInteger() * depth;//add the integers to the sum multiplied by the depth
                    }
                    else
                    {
                        x.GetList().ToList().ForEach(f => q.Enqueue(f));//implementation add all children elements to the queue, sinze we took a 
                                                                        //snapshot of the size, enqueuing at any time won't modify the loop
                    }
                }
                depth++;//each time we are done with an iteration, add to the depth
            }

            return curSum;

        }

        //If the currest nested integer is just an integer, add it to the sum multiplied by the depth, otherwise increase
        //the depth and call the function by again
        public int DepthFirstSearch(IList<NestedInteger> nestedList, int depth)
        {
            int curSum = 0;
            foreach (NestedInteger nestedInt in nestedList)
            {
                if (nestedInt.IsInteger())
                {
                    curSum += nestedInt.GetInteger() * depth;
                }
                else
                {
                    curSum += DepthFirstSearch(nestedInt.GetList(), depth + 1);
                }
            }
            return curSum;
        }


    }
}
