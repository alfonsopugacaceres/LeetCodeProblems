using NUnit.Framework;
using LeetCodeProblems.Problems.AmazonProblems;

namespace LeetCodeTesting
{
    class AmazonFreshTest
    {
        [Test]
        public void Edgetesting()
        {
            AmazonFresh amazonfresh = new AmazonFresh();

            string[] shoppingCart = null;
            string[][] winningItems = null;
            bool result = amazonfresh.Solve(winningItems, shoppingCart);
            Assert.AreEqual(false, result);

            shoppingCart = new string[3];
            shoppingCart[0] = "apple";
            shoppingCart[1] = "orange";
            shoppingCart[2] = "apple";
            result = amazonfresh.Solve(winningItems, shoppingCart);
            Assert.AreEqual(false, result);

            shoppingCart = null;
            winningItems = new string[2][];
            winningItems[0] = new string[2] { "apple", "orange" };
            winningItems[1] = new string[2] { "pear", "pear" };
            result = amazonfresh.Solve(winningItems, shoppingCart);
            Assert.AreEqual(false, result);
        }

        [Test]
        public void WinningTest()
        {
            AmazonFresh amazonfresh = new AmazonFresh();

            string[] shoppingCart = null;
            shoppingCart = new string[6];
            shoppingCart[0] = "orange";
            shoppingCart[1] = "apple";
            shoppingCart[2] = "apple";
            shoppingCart[3] = "banana";
            shoppingCart[4] = "orange";
            shoppingCart[5] = "banana";

            string[][] winningItems = null;
            winningItems = new string[2][];
            winningItems[0] = new string[2] { "apple", "apple" };
            winningItems[1] = new string[3] { "banana", "anything", "banana" };
            bool result = amazonfresh.Solve(winningItems, shoppingCart);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void WrongOrderTest()
        {
            AmazonFresh amazonfresh = new AmazonFresh();

            string[] shoppingCart = null;
            shoppingCart = new string[6];
            shoppingCart[0] = "orange";
            shoppingCart[1] = "apple";
            shoppingCart[2] = "apple";
            shoppingCart[3] = "banana";
            shoppingCart[4] = "orange";
            shoppingCart[5] = "banana";

            string[][] winningItems = null;
            winningItems = new string[2][];
            winningItems[0] = new string[3] { "banana", "anything", "banana" };
            winningItems[1] = new string[2] { "apple", "apple" };
            bool result = amazonfresh.Solve(winningItems, shoppingCart);
            Assert.AreEqual(false, result);
        }

        [Test]
        public void NeverCorrectFirstList()
        {
            AmazonFresh amazonfresh = new AmazonFresh();

            string[] shoppingCart = null;
            shoppingCart = new string[6];
            shoppingCart[0] = "apple";
            shoppingCart[1] = "banana";
            shoppingCart[2] = "apple";
            shoppingCart[3] = "banana";
            shoppingCart[4] = "orange";
            shoppingCart[5] = "banana";

            string[][] winningItems = null;
            winningItems = new string[2][];
            winningItems[0] = new string[2] { "apple", "apple" };
            winningItems[1] = new string[3] { "banana", "anything", "banana" };
            bool result = amazonfresh.Solve(winningItems, shoppingCart);
            Assert.AreEqual(false, result);
        }

        [Test]
        public void NotEnoughFruits()
        {
            AmazonFresh amazonfresh = new AmazonFresh();

            string[] shoppingCart = null;
            shoppingCart = new string[4];
            shoppingCart[0] = "apple";
            shoppingCart[1] = "apple";
            shoppingCart[2] = "apple";
            shoppingCart[3] = "banana";

            string[][] winningItems = null;
            winningItems = new string[2][];
            winningItems[0] = new string[2] { "apple", "apple" };
            winningItems[1] = new string[3] { "apple", "apple", "banana" };
            bool result = amazonfresh.Solve(winningItems, shoppingCart);
            Assert.AreEqual(false, result);
        }
    }
}
