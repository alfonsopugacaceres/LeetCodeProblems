using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.HashTable.SortIntegersByPowerValue
{
    class SortIntegersByPowerValue
    {
        //1387. Sort Integers by The Power Value

        //The power of an integer x is defined as the number of steps needed to transform x into 1 using the following steps:
        //if x is even then x = x / 2
        //if x is odd then x = 3 * x + 1
        //For example, the power of x = 3 is 7 because 3 needs 7 steps to become 1 (3 --> 10 --> 5 --> 16 --> 8 --> 4 --> 2 --> 1).
        //Given three integers lo, hi and k.The task is to sort all integers in the interval [lo, hi] by the power value in ascending order, if two or more integers have the same power value sort them by ascending order.
        //Return the kth integer in the range [lo, hi] sorted by the power value.
        //Notice that for any integer x (lo <= x <= hi) it is guaranteed that x will transform into 1 using these steps and that the power of x is will fit in a 32-bit signed integer.
        public int GetKth(int lo, int hi, int k)
        {
            var list = new List<Item>();
            IDictionary<int, int> memo = new Dictionary<int, int>();

            for (int i = lo; i <= hi; i++)
                list.Add(new Item(i, getPower(i, memo)));

            list = list.OrderBy(x => x.Power).ThenBy(x => x.Num).ToList();

            return list[k - 1].Num;
        }

        int getPower(int num, IDictionary<int,int> memo)
        {
            int steps = 0;
            while (num > 1)
            {
                if (memo.ContainsKey(num))
                    num = memo[num];
                else if (num % 2 == 0)
                {
                    memo.Add(num,num /= 2);
                    num = memo[num];
                }
                else
                {
                    memo.Add(num, 3 * num + 1);
                    num = memo[num];
                }
                steps++;
            }
            return steps;
        }
        int getPower1(int num, IDictionary<int, int> memo)
        {
            int steps = 0;
            while (num > 1)
            {
                if (num % 2 == 0)
                    num /= 2;
                else
                    num = 3 * num + 1;
                steps++;
            }
            return steps;
        }
        public class Item
        {
            public int Num { get; set; }
            public int Power { get; set; }

            public Item(int num, int steps)
            {
                Num = num;
                Power = steps;
            }
        }
    }
}
