using NUnit.Framework;
using LeetCodeProblems.Problems.AmazonProblems;

namespace LeetCodeTesting
{
    public class SpiralMatrixTest
    {
        [Test]
        public void BasicTest()
        {
            SpiralMatrix spiralMatrix = new SpiralMatrix();
            spiralMatrix.generatematrix(3);
        }
    }
}
