using NUnit.Framework;
using LeetCodeProblems.Problems;
using Microsoft.VisualBasic.FileIO;
using System;

namespace LeetCodeTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ScopeTest()
        {
            TwoSum twoSum = new TwoSum();

            int[] tooSmall = new int[1];
            int target = 0;
            int[] result = null;

            result = twoSum.Solve(tooSmall, target);
            Assert.Null(result);
            tooSmall = null;

            int[] tooLarge = new int[100001];
            target = 0;
            result = twoSum.Solve(tooLarge, target);
            Assert.Null(result);
            tooLarge = null;

            int[] nums = new int[5];
            target = -1000000001;
            result = twoSum.Solve(nums, target);
            Assert.Null(result);


            target = 1000000001;
            result = twoSum.Solve(nums, target);
            Assert.Null(result);
            
            Assert.Pass();
        }

        [Test]
        public void BasicTest()
        {
            TwoSum twoSum = new TwoSum();

            int[] nums = new int[5];
            int target = 13;
            int[] result = null;

            nums[0] = 3;
            nums[1] = 2;
            nums[2] = 9;
            nums[3] = 1;
            nums[4] = 10;


            result = twoSum.Solve(nums, target);
            Assert.NotNull(result);
            Assert.AreEqual(result.Length, 2);
            Assert.AreEqual(result[0], 0);
            Assert.AreEqual(result[1], 4);

            Assert.Pass();
        }
    }
}