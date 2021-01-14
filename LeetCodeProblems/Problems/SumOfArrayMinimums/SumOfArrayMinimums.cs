//using System.Collections.Generic;

//public class SumOfarrayMinimums
//{
//    public int SumSubarrayMins(int[] arr)
//    {

//        if (arr.Length < 1 || arr.Length > 30000)
//        {
//            return -1;
//        }
//        else
//        {
//            Stack<int> leftStack = new Stack<int>();
//            Stack<int> rightStack = new Stack<int>();
//            int[] leftMin = new int[arr.Length];
//            int[] rightMin = new int[arr.Length];

//            //This section of the code sets the left mins and right mins to assume the current i is indeed the minimum
//            //This is the base case for the entire algorithm
//            //Given 4 2 9 3
//            //leftmin = 0 1 2 3
//            //rightmin = 3 2 1 0
//            //This causes the sliding comparison to start at both extremes
//            for (int i = 0; i < arr.Length; i++)
//            {
//                leftMin[i] = i;
//                rightMin[i] = arr.Length - i - 1;
//            }

//            for (int i = 0; i < arr.Length; i++)
//            {
//                while (leftStack.Count > 0 && arr[leftStack.Peek()] > arr[i])
//                {
//                    leftMin[leftStack.Peek()] = leftStack.Peek() - i - 1;
//                    leftStack.Pop();
//                }
//                leftStack.Push(i);
//            }

//            for (int i = arr.Length - 1; i >= 0; i--)
//            {
//                while(leftStack.Count > 0 && arr[leftStack.Peek()] > arr[i])
//                {
//                    leftStack.Pop();
//                }
//                leftMin[i] = (leftStack.Count <= 0) ? i + 1 : i - leftStack.Peek();
//                leftStack.Push(i);

//            }
//        }
//    }
//}