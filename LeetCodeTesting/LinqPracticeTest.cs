using NUnit.Framework;
using LeetCodeProblems.Problems;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using LeetCodeProblems.Linq;

namespace LeetCodeTesting
{
    public class LinqPracticeTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NumbersFromRangeTest()
        {
            IList<int> nums = new List<int>();
            nums.Add(67);
            nums.Add(92);
            nums.Add(153);
            nums.Add(15);
            LinqPractice practiceClass = new LinqPractice();

            IList<int> res = practiceClass.NumbersFromRange(nums);

            Assert.AreEqual(res.Count, 2);
            Assert.IsTrue(res.Contains(67));
            Assert.IsTrue(res.Contains(92));
            for (int i = 0; i < res.Count; i++)
                Console.WriteLine("List item #{0} = {1}", i, res[i]);

        }

        [Test]
        public void Min5LettersUppercaseTest()
        {
            IList<string> input = new List<string>();
            input.Add("computer");
            input.Add("dota2");
            input.Add("dddd");
            input.Add("Kevin");
            LinqPractice practiceClass = new LinqPractice();

            IList<string> res = practiceClass.Min5LettersUppercase(input);
            Assert.AreEqual(res.Count, 1);
            Assert.IsTrue(res.Contains("COMPUTER"));
            for (int i = 0; i < res.Count; i++)
                Console.WriteLine("List item #{0} = {1}", i, res[i]);




        }
    }
}
