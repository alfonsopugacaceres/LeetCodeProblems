using NUnit.Framework;
using LeetCodeProblems.Problems.AmazonProblems;
namespace LeetCodeTesting
{
    class AmazonMusicPairsTest
    {
        [Test]
        public void EdgeTest()
        {
            AmazonMusicPairs musicPairs = new AmazonMusicPairs();
            int[] music = new int[160];

            int result = musicPairs.Solve(music);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void BasicTest()
        {
            AmazonMusicPairs musicPairs = new AmazonMusicPairs();
            int[] music = new int[3];
            music[0] = 60;
            music[1] = 60;
            music[2] = 60;

            int result = musicPairs.Solve(music);
            Assert.AreEqual(3, result);


            music = new int[5];
            music[0] = 30;
            music[1] = 20;
            music[2] = 150;
            music[3] = 100;
            music[4] = 40;

            result = musicPairs.Solve(music);
            Assert.AreEqual(3, result);


            music = new int[5];
            music[0] = 60;
            music[1] = 120;
            music[2] = 180;
            music[3] = 240;
            music[4] = 300;

            result = musicPairs.Solve(music);
            Assert.AreEqual(10, result);
        }

    }
}
