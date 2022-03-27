using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Classes
{
    public class MinStack
    {
        IList<int> _minList;
        IList<int> _stack;

        public MinStack()
        {
            _minList = new List<int>();
            _stack = new List<int>();
        }

        public void Push(int val)
        {
            _stack.Insert(0, val);
            _minList.Add(val);
            _minList = _minList.OrderBy(f => f).ToList();
        }

        public void Pop()
        {
            int toRemove = _stack[0];
            _stack.RemoveAt(0);
            _minList.RemoveAt(_minList.IndexOf(toRemove));
            _minList = _minList.OrderBy(f => f).ToList();
        }

        public int Top()
        {
            if (_stack.Count > 0)
                return _stack[0];
            else
                throw new Exception();

        }

        public int GetMin()
        {
            if (_minList.Count > 0)
                return _minList[0];
            else
                throw new Exception();
        }
    }

    class MinStack2
    {

        private Stack<int> stack = new Stack<int>();
        private Stack<int[]> minStack = new Stack<int[]>();


        public MinStack2() { }


        public void push(int x)
        {

            // We always put the number onto the main stack.
            stack.Push(x);

            // If the min stack is empty, or this number is smaller than
            // the top of the min stack, put it on with a count of 1.
            if (minStack.Count > 0 || x < minStack.Peek()[0])
            {
                minStack.Push(new int[] { x, 1 });
            }

            // Else if this number is equal to what's currently at the top
            // of the min stack, then increment the count at the top by 1.
            else if (x == minStack.Peek()[0])
            {
                minStack.Peek()[1]++;
            }
        }


        public void pop()
        {

            // If the top of min stack is the same as the top of stack
            // then we need to decrement the count at the top by 1.
            if (stack.Peek() == minStack.Peek()[0])
            {
                minStack.Peek()[1]--;
            }

            // If the count at the top of min stack is now 0, then remove
            // that value as we're done with it.
            if (minStack.Peek()[1] == 0)
            {
                minStack.Pop();
            }

            // And like before, pop the top of the main stack.
            stack.Pop();
        }


        public int top()
        {
            return stack.Peek();
        }


        public int getMin()
        {
            return minStack.Peek()[0];
        }
    }
}
