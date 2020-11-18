using NUnit.Framework;
using LeetCodeProblems.Problems.AmazonProblems;

namespace LeetCodeTesting
{
    public class ArrayRankTransformTest
    {
        //[Test]
        //public void BasicTest()
        //{
        //    SpiralMatrix spiralMatrix = new SpiralMatrix();
        //    spiralMatrix.generatematrix(3);
        //}
        [Test]
        public void BasicTest()
        {
            ArrayRankTransformProblem arrayRankTransform = new ArrayRankTransformProblem();
            arrayRankTransform.ArrayRankTransform(new int[] { 40, 10, 20, 30 });
        }
    }
}
