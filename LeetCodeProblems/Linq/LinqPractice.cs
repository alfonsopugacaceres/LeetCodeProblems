using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.Linq
{
    public class LinqPractice
    {
        //Given an array of integers, write a query that returns list of numbers greater than 30 and less than 100.
        public IList<int> NumbersFromRange(IList<int> nums)
        {
            return nums.Where(f => f > 30 && f < 100).ToList();
        }

        public IList<string> Min5LettersUppercase(IList<string> input)
        {
            return input.Where(f => f.Length > 5).Select(r => r.ToUpper()).ToList();
        }

        public IList<string>
    }
}
