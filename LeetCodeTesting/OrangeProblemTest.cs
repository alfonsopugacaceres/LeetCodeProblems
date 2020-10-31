using NUnit.Framework;
using LeetCodeProblems.Problems.AmazonProblems;
namespace LeetCodeTesting
{
    public class OrangeProblemTest
    {

        [Test]
        public void OrangeSingleRowImpossibleTest()
        {
            int[][] oranges = new int[1][];
            for(int i = 0; i < oranges.Length; i++)
            {
                oranges[i] = new int[2];
            }

            oranges[0][0] = 0;
            oranges[0][1] = 1;


            OrangeProblem orangeProblem = new OrangeProblem();
            Assert.AreEqual(-1,orangeProblem.OrangesRotting(oranges));
        }
        [Test]
        public void OrangeSingleRowPossibleTest()
        {
            int[][] oranges = new int[1][];
            for (int i = 0; i < oranges.Length; i++)
            {
                oranges[i] = new int[2];
            }

            oranges[0][0] = 1;
            oranges[0][1] = 2;


            OrangeProblem orangeProblem = new OrangeProblem();
            Assert.AreEqual(1, orangeProblem.OrangesRotting(oranges));
        }
        [Test]
        public void OrangeSingleRowPossibleTestLarge()
        {
            int[][] oranges = new int[1][];
            for (int i = 0; i < oranges.Length; i++)
            {
                oranges[i] = new int[5];
            }

            oranges[0][0] = 2;
            oranges[0][1] = 2;
            oranges[0][2] = 2;
            oranges[0][3] = 1;
            oranges[0][4] = 1;


            OrangeProblem orangeProblem = new OrangeProblem();
            Assert.AreEqual(2, orangeProblem.OrangesRotting(oranges));
        }
    }
}
