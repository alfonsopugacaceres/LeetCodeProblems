using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.Notes
{
    public class ImportantConcepts
    {
        public class BinaryTreeNode
        {
            public int val { get; set; }
            public BinaryTreeNode left { get; set; }
            public BinaryTreeNode right { get; set; }
        }

        #region DepthFirstSearch

        //https://www.youtube.com/watch?v=utDu3Q7Flrw&list=PLot-Xpze53ldBT_7QA8NVot219jFNr_GI
        //https://seanprashad.com/leetcode-patterns/
        //https://www.youtube.com/watch?v=tWVWeAqZ0WU

        /// <summary>
        /// In Order Traversal for a binary tree, we use the list to store the values in the correct order
        /// note the left most root shows up first, then the middle node, then the right hand side
        /// </summary>
        /// <param name="root">root of the binary tree</param>
        /// <param name="ret">list to populate with the values of the tree</param>
        public void InOrderTraversal(BinaryTreeNode root, IList<int> ret)
        {
            if (root == null)//if the root is null just return out of the function
                return;
            if (root.left != null)//if the root left is not null run the recursive call on the left
                InOrderTraversal(root.left, ret);

            ret.Add(root.val);//add the current root to the list after completing the stack calls on the left

            if (root.right != null)//if the root right is not null run the recursive calls on the right
                InOrderTraversal(root.right, ret);
        }

        /// <summary>
        /// Post Order Traversal for a binary tree, we use the list to store the values in the correct order
        /// note the right most root shows up first, then the middle node, then the left node
        /// </summary>
        /// <param name="root">root of the binary tree</param>
        /// <param name="ret">list to populate with the values of the tree</param>
        public void PostOrderTraversal(BinaryTreeNode root, IList<int> ret)
        {
            if (root == null)//if the root is null just return out of the function
                return;

            if (root.right != null)//if the root right is not null run the recursive calls on the right
                PostOrderTraversal(root.right, ret);

            ret.Add(root.val);//add the current root to the list after completing the stack calls on the left

            if (root.left != null)//if the root left is not null run the recursive call on the left
                PostOrderTraversal(root.left, ret);

        }

        /// <summary>
        /// Pre Order Traversal for a binary tree, we use the list to store the values in the correct order.
        /// note roots always show first in this traversal
        /// </summary>
        /// <param name="root">root of the binary tree</param>
        /// <param name="ret">list to populate with the values of the tree</param>
        public void PreOrderTraversal(BinaryTreeNode root, IList<int> ret)
        {
            if (root == null)
                return;

            ret.Add(root.val);//add the current root to the list after completing the stack calls on the left

            if (root.left != null)//if the root left is not null run the recursive call on the left
                PreOrderTraversal(root.left, ret);

            if (root.right != null)//if the root right is not null run the recursive calls on the right
                PreOrderTraversal(root.right, ret);

        }

        /// <summary>
        /// Breath first traversals print out the values based on level of the tree.
        /// by leveraging a queue we can make sure to print out based on FIFO mode, allowing 
        /// us to enqueue more items without altering the result.
        /// </summary>
        /// <param name="root">root of the binary tree</param>
        /// <param name="ret">list to populate with the values of the tree</param>
        public void BreadthFirstTraversal(BinaryTreeNode root, IList<int> ret)
        {
            if (root == null)
                return;

            Queue<BinaryTreeNode> queue = new Queue<BinaryTreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                BinaryTreeNode curVal = queue.Dequeue();
                ret.Add(curVal.val);

                if (root.left != null)
                    queue.Enqueue(root.left);
                if (root.right != null)
                    queue.Enqueue(root.right);
            }
        }

        #endregion

        #region Dynamic Programming

        //Dynamic programming is known as the art of accumulating subproblems to resolve very complex issues


        /// <summary>
        /// Fibonacci Number Pattern (Leetcode #70 Climbing Stairs https://leetcode.com/problems/climbing-stairs/)
        /// Bottom up Dynamic Problem Approach
        /// </summary>
        /// <param name="n">Number of steps to the top</param>
        /// <returns>Distinct ways to go up the stairs</returns>
        /// <remarks>The Fibonacci number pattern is characterized by making decisions that happen one at a time, 
        /// then we accumulate the different ways to make our decision, we step forward and we repeat the same process.
        /// As we progress through the problem we perform the same operations and we accumulate our possibilites leveraging 
        /// the already calculated previous possibilities</remarks>
        public int ClimbStairs(int n)
        {
            if (n == 1)//to climb 1 stair we can only do it one way
                return 1;
            else if (n == 2)//to climb 2 stairs we can do it two different ways, 1->1 and 2->
                return 2;
            else
            {
                int waysToClimb = 0;
                int prev1 = 2;
                int prev2 = 1;
                //The pattern is as follows: F(X-2) + F(X-1) = F(X). It is much easier to find patterns for this type of question
                //by writting up a decision tree and seeing we are repeating accumulations subproblems
                for (int i = 3; i <= n; i++)//notice the loop bounds and the loop exit condition
                {
                    waysToClimb = prev1 + prev2;
                    prev2 = prev1;
                    prev1 = waysToClimb;
                }

                return waysToClimb;//return answer
            }
        }

        public int Rob(int[] nums)
        {
            int robChoice1 = 0, robChoice2 = 0;

            //The trick with this problem is how we can process the array dynamically and keeping track of the previous 2 steps to find
            //the maximum amount.
            //Take a look at the following example array [1,2,3,4]
            //Lets first visit house 0, the MAX we can get from this house is 1
            //Lets take a visit to house 1, the Max we can get from this house is either avoid house 0 and take house 1, or take house 0
            //This means Max(House[0], House[1]), because we can always just not rob house 1 and stick to house 0 if it had more money
            //Now take a look at house 2, since the condition states, ROBBING TWO ADJACENT HOUSES SETS OFF THE ALARM, we can either 
            //Take house 2 + house 0 avoiding house 2 OR we can take house 1. 
            //Therefore house 2 = Math.Max(house2 + house 0, house 1);
            //The same thing for house 3, house 3 = Math.Max(house[3] + house[1], house[2])
            //As we progress through the array we update the values with the maxes, this way we can always make sure we get the largest value
            for (int i = 0; i < nums.Length; i++)
            {
                int curMax = Math.Max(nums[i] + robChoice1, robChoice2);
                robChoice1 = robChoice2;
                robChoice2 = curMax;
            }

            return robChoice2;
        }
        /// <summary>
        /// Dynamic programming question for fibonacci numbers, the trick here is remembering that FIB(N) = FIB(N-1) + FIB(N-2)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int Fib(int n)
        {
            int fib1 = 0;
            int fib2 = 1;


            if (n <= 0)
                return 0;
            else if (n == 1)
                return 1;
            else
            {
                int res = -1;
                for (int i = 2; i <= n; i++)
                {
                    res = fib1 + fib2;
                    fib1 = fib2;
                    fib2 = res;
                }
                return res;
            }
        }

        /// <summary>
        /// This is the wrapper function for calling the recursive fibonnacci function
        /// </summary>
        /// <param name="n"></param>
        /// <returns>nth fibonnaci number</returns>
        public int CalculateFib(int n)
        {
            return RecursiveFib(n);
        }

        /// <summary>
        /// Recursive fibonnaci number function. We know the base cases, which are FIB(0) == 0 and FIB(1)==1, then we can calculate all other numbers
        /// by slamming our stack with fibonnaci number calls since FIB(N) = FIB(N-1) + FIB(N-2). We just recursively call the function while subtracting 
        /// from N until we reach the base case, 0 and 1
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int RecursiveFib(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return RecursiveFib(n - 1) + RecursiveFib(n - 2);
        }
        /// <summary>
        /// REcursiveFibMemoWrapper function to call our recursive one
        /// </summary>
        /// <param name="n"></param>
        /// <returns>nth fib number</returns>
        public int RecursiveFibMemoWrapper(int n)
        {
            IDictionary<int, int> fibDictionary = new Dictionary<int, int>();
            return RecursiveFibMemo(n, fibDictionary);
        }

        /// <summary>
        /// The dictionary we introduce allows us to reuse our previously calculated values and dramatically increase perfirmace
        /// </summary>
        /// <param name="n"></param>
        /// <param name="fibDictionary">memoization of previously calculated fib numbers</param>
        /// <returns>the nth fib number</returns>
        public int RecursiveFibMemo(int n, IDictionary<int, int> fibDictionary)
        {
            if (fibDictionary.ContainsKey(n))
                return fibDictionary[n];
            else
            {
                if (n == 0)
                    return 0;
                else if (n == 1)
                    return 1;
                else
                {
                    fibDictionary.Add(n, RecursiveFibMemo(n - 1, fibDictionary) + RecursiveFibMemo(n - 2, fibDictionary));
                    return fibDictionary[n];
                }
            }
        }



        public int GridTraveler(int m, int n)
        {
            return GridTravelerHelper(m, n);
        }

        public int GridTravelerHelper(int m, int n)
        {
            if (m == 0 || n == 0)
                return 0;
            else if (m == 1 && n == 1)
                return 1;
            else
                return GridTravelerHelper(m - 1, n) + GridTravelerHelper(m, n - 1);
        }
        public int GridTravelerMemo(int m, int n)
        {
            IDictionary<(int, int), int> dict = new Dictionary<(int, int), int>();
            return GridTravelerMemoHelper(m, n, dict);
        }

        public int GridTravelerMemoHelper(int m, int n, IDictionary<(int, int), int> memo)
        {
            if (memo.ContainsKey((m, n)))
                return memo[(m, n)];
            if (m == 0 || n == 0)
                return 0;
            else if (m == 1 && n == 1)
                return 1;
            else
            {
                memo.Add((m, n), GridTravelerMemoHelper(m - 1, n, memo) + GridTravelerMemoHelper(m, n - 1, memo));
                return memo[(m, n)];
            }
        }


        public bool CanSum(int target, int[] nums)
        {
            if (target == 0)
                return true;
            else if (target < 0)
                return false;
            else
            {
                for (int i = 0; i < nums.Length; i++)
                    if (CanSum(target - nums[i], nums))
                        return true;
            }
            return false;
        }


        public bool CanSumMemo(int target, int[] nums, IDictionary<int, bool> checkerMemo)
        {
            if (checkerMemo.ContainsKey(target))
                return true;
            if (target == 0)
                return true;
            else if (target < 0)
                return false;
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (CanSumMemo(target - nums[i], nums, checkerMemo))
                    {
                        checkerMemo[target] = true;
                        return true;
                    }
                }
            }
            return false;
        }



        public int[] HowSumWrapper(int target, int[] nums)
        {
            IList<int> answer = HowSum(target, nums);
            return answer.ToArray();
        }

        public IList<int> HowSum(int target, int[] nums)
        {
            if (target == 0)
                return new List<int>();
            if (target < 0)
                return null;
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    IList<int> ret = HowSum(target - nums[i], nums);
                    if (ret != null)
                    {
                        ret.Add(nums[i]);
                        return ret;
                    }
                }
            }
            return null;
        }
        public IList<int> HowSum(int target, int[] nums, IDictionary<int, IList<int>> memo)
        {
            if (memo.ContainsKey(target))
                return memo[target];
            if (target == 0)
                return new List<int>();
            if (target < 0)
                return null;
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    memo.Add(target, HowSum(target - nums[i], nums));
                    if (memo[target] != null)
                    {
                        memo[target].Add(nums[i]);
                        return memo[target];
                    }
                }
            }
            memo.Add(target, null);
            return memo[target]; ;
        }

        public IList<int> BestSum(int targetSum, int[] numbers, IDictionary<int, IList<int>> memo)
        {
            if (memo.ContainsKey(targetSum))
                return memo[targetSum];
            if (targetSum == 0)
                return new List<int>();
            else if (targetSum < 0)
                return null;

            IList<int> shortestCombination = null;
            for (int i = 0; i < numbers.Length; i++)
            {
                int remainder = targetSum - numbers[i];
                IList<int> temp = BestSum(remainder, numbers, memo);
                if (memo[remainder] != null)
                {
                    temp.Add(remainder);
                    if (shortestCombination == null || temp.Count < shortestCombination.Count)
                    {
                        shortestCombination = temp;
                    }
                }
            }

            memo[targetSum] = shortestCombination;
            return shortestCombination;

        }

        public bool canConstruct(string target, string[] wordbank)
        {
            if (target == string.Empty)
                return true;

            for (int i = 0; i < wordbank.Length; i++)
            {
                bool found = false;
                if (target.IndexOf(wordbank[i]) == 0)
                {
                    if (canConstruct(target.Substring(wordbank.Length - 1, target.Length - wordbank.Length), wordbank))
                        return true;
                }
            }
            return false;
        }



        public bool canConstruct(string target, string[] wordbank, IDictionary<string, bool> memo)
        {
            if (memo.ContainsKey(target))
                return memo[target];
            if (target == string.Empty)
                return true;

            for (int i = 0; i < wordbank.Length; i++)
            {
                if (target.IndexOf(wordbank[i]) == 0)
                {
                    if (canConstruct(target.Substring(wordbank[i].Length - 1, target.Length - wordbank[i].Length), wordbank, memo))
                    {
                        memo.Add(target, true);
                        return memo[target];
                    }
                }
            }
            memo.Add(target, false);
            return memo[target];

        }


        public int countConstruct(string target, string[] wordbank)
        {
            if (string.IsNullOrEmpty(target))
                return 1;
            int totalCount = 0;
            for (int i = 0; i < wordbank.Length; i++)
            {
                if (target.IndexOf(wordbank[i]) == 0)
                {
                    totalCount += countConstruct(target.Substring(wordbank[i].Length - 1, target.Length - wordbank[i].Length), wordbank);
                }
            }

            return totalCount;
        }

        public int countConstruct(string target, string[] wordbank, IDictionary<string, int> memo)
        {
            if (memo.ContainsKey(target))
                return memo[target];

            if (string.IsNullOrEmpty(target))
                return 1;
            int totalCount = 0;
            for (int i = 0; i < wordbank.Length; i++)
            {
                if (target.IndexOf(wordbank[i]) == 0)
                {
                    totalCount += countConstruct(target.Substring(wordbank[i].Length - 1, target.Length - wordbank[i].Length), wordbank);
                }
            }

            memo.Add(target, totalCount);
            return memo[target];
        }

        //public IList<IList<string>> allConstruct(string target, string[] wordBank)
        //{
        //    if (target == string.Empty)
        //        return new List<IList<string>>();

        //    IList<IList<string>> result = new List<IList<string>>();

        //    for (int i = 0; i < wordBank.Length; i++)
        //    {
        //        if (target.IndexOf(wordBank[i]) == 0)
        //        {
        //            IList<IList<string>> x = allConstruct(target.Substring(wordBank[i].Length - 1, target.Length - wordBank[i].Length), wordBank);
        //            if(x != null)
        //            {
        //                result.Add(new List<string>());
        //                for (int j = 0; j < x.Count; j++)
        //                {
        //                    x[i].Add(target);
        //                    result[i].Add(x[i]);
        //                }
        //            }
        //        }
        //    }
        //    return result;
        //}


        #region Tabulation

        ///Tabulation Recipe
        ///-Visualize the problem as a table
        ///-Size the table based on the input variables
        ///-Initialize the table with some default values
        ///-Seed the trivial answers into the table
        ///-Iterate through the table that fills positions further along the table based on the current position

        public int TabulatedFibonacci(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
            {
                int[] fibNumTable = new int[n + 2];
                for(int i = 0; i <= n; i++)
                {
                    fibNumTable[i + 1] += fibNumTable[i];
                    fibNumTable[i + 2] += fibNumTable[i];
                }
                return fibNumTable[n];
            }
        }


        public int TabulatedTravelerProblem(int m, int n)
        {
            int[][] grid = new int[m + 1][];
            for (int i = 0; i < grid.Length; i++)
                grid[i] = new int[n + 1];

            grid[1][1] = 1;

            for(int i = 0; i < grid.Length; i++)
            {
                for(int j = 0; j < grid[i].Length; j++)
                {
                    if (j + 1 < grid[i].Length)
                        grid[i][j + 1] += grid[i][j];
                    if (i + 1 < grid.Length)
                        grid[i+1][j] += grid[i][j];
                }
            }

            return (grid[grid.Length - 1][grid[grid.Length - 1].Length - 1]);
        }


        public bool TabulatedCanSum(int targetSum, int[] numbers)
        {
            int [] table = new int[targetSum+1];
            table[0] = 1;

            for(int i = 0; i < table.Length; i++)
            {
                if(table[i] == 1)
                    for (int j = 0; j < numbers.Length; j++)
                        if (numbers[j] + i < table.Length)
                            table[i + numbers[j]] = 1;
            }

            return (table[targetSum] == 1);

        }


        public IList<int> TabulatedHowSum(int targetSum, int[] numbers)
        {
            IList<IList<int>> table = new List<IList<int>>();
            for(int i = 0; i < targetSum + 1; i++)
                table.Add(new List<int>());

            table[0].Add(0);

            for (int i = 0; i < table.Count; i++)
            {
                if (table[i].Count > 0)
                {
                    table[i] = new List<int>();

                    for (int j = 0; j < numbers.Length; j++)
                        if (table[i].Count + numbers[j] < table.Count)
                            table[i].Add(numbers[j]);

                }
            }

            return (table[targetSum]);
        }

        //public int[] TabulatedBestSum(int targetSum, int[] numbers)
        //{
        //    int[][] table = new int[targetSum + 1][];
        //    table[0] = new int[numbers.Length];

        //    for(int i = 0; i < table.Length; i++)
        //    {
        //        if(table[i] != null)
        //        {
        //            for(int j = 0; j < numbers.Length; j++)
        //            {
        //                if(i + numbers[j] < table.Length)
        //                {
        //                    table[i + numbers[j]] = new int[numbers.Length];

        //                }
        //            }
        //        }
        //    }

        //}

        #endregion

        #region Graphs

        public class GraphNode
        {
            public char Value { get; set; }
            public IList<GraphNode> neighbors { get; set; }
        }
        public string DepthFirstTraversalGraph(GraphNode startNode)
        {
            Stack<GraphNode> stack = new Stack<GraphNode>();
            stack.Push(startNode);
            StringBuilder ret = new StringBuilder();


            while(stack.Count > 0)
            {
                GraphNode current = stack.Pop();

                ret.Append(current.Value);

                foreach(GraphNode node in current.neighbors)
                    stack.Push(node);

            }

            return ret.ToString();

        }


        public string BreathFirstTraversalGraph(char startNode, IDictionary<char, char[]> adjacencyList)
        {
            Queue<char> q = new Queue<char>();

            StringBuilder ret = new StringBuilder();
            q.Enqueue(startNode);

            while(q.Count > 0)
            {
                char current = q.Dequeue();
                ret.Append(current);

                foreach(char c in adjacencyList[current])
                {
                    q.Enqueue(c);
                }
            }

            return ret.ToString();
        }

        public bool HasPath(char source, char destination, IDictionary<char, char[]> adjacencyList)
        {
            Stack<char> s = new Stack<char>();
            s.Push(source);

            while(s.Count > 0)
            {
                char current = s.Pop();


                foreach(char c in adjacencyList[current])
                {
                    if (c == destination)
                        return true;
                    s.Push(c);
                }
            }

            return false;


        }

        public IDictionary<char, char[]> EdgeListToAdjacencyList(char[][] edgeList)
        {
            IDictionary<char, char[]> adjacencyList = new Dictionary<char, char[]>();
            foreach(char [] arr in edgeList)
            {
                if (!adjacencyList.ContainsKey(arr[0]))
                    adjacencyList.Add(arr[0], new char[arr.Length - 2]);
                for (int i = 1; i < arr.Length; i++)
                    adjacencyList[arr[0]][i] = arr[i];
            }

            return adjacencyList;
        }
        public IDictionary<char, IList<char>> EdgeListToAdjacencyListUndirectedGraph(char[][] edgeList)
        {
            IDictionary<char, IList<char>> adjacencyList = new Dictionary<char, IList<char>>();
            foreach (char[] arr in edgeList)
            {
                //edges in this case only have 2 slots

                if (!adjacencyList.ContainsKey(arr[0]))
                    adjacencyList.Add(arr[0], new List<char>());
                if (!adjacencyList.ContainsKey(arr[1]))
                    adjacencyList.Add(arr[1], new List<char>());

                adjacencyList[arr[0]].Add(arr[1]);
                adjacencyList[arr[1]].Add(arr[0]);

            }

            return adjacencyList;
        }






        #endregion




        #endregion
    }


}
