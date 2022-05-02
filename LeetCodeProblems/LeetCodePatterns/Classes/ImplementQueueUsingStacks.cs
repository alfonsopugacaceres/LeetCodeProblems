using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Classes
{
    class ImplementQueueUsingStacks
    {
//        Implement a first in first out (FIFO) queue using only two stacks.The implemented queue should support all the functions of a normal queue (push, peek, pop, and empty).

//Implement the MyQueue class:

//void push(int x) Pushes element x to the back of the queue.
//int pop() Removes the element from the front of the queue and returns it.
//int peek() Returns the element at the front of the queue.
//boolean empty() Returns true if the queue is empty, false otherwise.
//Notes:

//You must use only standard operations of a stack, which means only push to top, peek/pop from top, size, and is empty operations are valid.
//Depending on your language, the stack may not be supported natively.You may simulate a stack using a list or deque(double-ended queue) as long as you use only a stack's standard operations.
        public class MyQueue
        {

            private Stack<int> s1;
            private Stack<int> s2;

            public MyQueue()
            {
                s1 = new Stack<int>();
                s2 = new Stack<int>();

            }

            public void Push(int x)
            {
                while(s1.Count > 0)
                    s2.Push(s1.Pop());
                s2.Push(x);
                while (s2.Count > 0)
                    s1.Push(s2.Pop());
            }

            public int Pop()
            {
                return s1.Pop();
            }

            public int Peek()
            {
                return s1.Peek();
            }

            public bool Empty()
            {
                return s1.Count <= 0;
            }
        }
    }
}
