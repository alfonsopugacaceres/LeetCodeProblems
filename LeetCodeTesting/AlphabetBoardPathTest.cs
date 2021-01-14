using System;
using System.Collections.Generic;
using System.Text;
using LeetCodeProblems.Problems.AlphabetBoardPath;
using NUnit.Framework;

namespace LeetCodeTesting
{
    public class AlphabetBoardPathTest
    {
        [Test]
        public void BasicTest()
        {
            AlphabetBoardPath x = new AlphabetBoardPath();
            x.AlphabetB("leet");
            Assert.Pass();

        }
    }
}
