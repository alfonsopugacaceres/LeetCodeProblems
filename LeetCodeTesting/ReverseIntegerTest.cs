using NUnit.Framework;
using LeetCodeProblems.Problems.ReverseInteger;

namespace LeetCodeTesting
{
    public partial class ReverseIntegerTest
    {

        [Test]
        public void BasicTest()
        {
            ReverseInteger reverseInteger = new ReverseInteger();

            int x = reverseInteger.Solve(-31);
            Assert.AreEqual(-13, x);


            x = reverseInteger.Solve(31);
            Assert.AreEqual(13, x);


            x = reverseInteger.Solve(2147483647);
            Assert.AreEqual(0, x);


            x = reverseInteger.Solve(1233847412);
            Assert.AreEqual(2147483321, x);


            x = reverseInteger.Solve(-1233847412);
            Assert.AreEqual(-2147483321, x);

            Assert.Pass();
        }
    }
}