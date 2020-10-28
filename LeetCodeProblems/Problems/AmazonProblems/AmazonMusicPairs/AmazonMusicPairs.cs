using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.AmazonProblems
{
    public class AmazonMusicPairs
    {
        public AmazonMusicPairs()
        {

        }

        public int Solve(int[] songs)
        {
            if(songs.Length < 1 || songs.Length > 105)
            {
                return 0;
            }

            IDictionary<int, int> remainderDict = new Dictionary<int, int>();


            int pairCount = 0;

            for (int i = 0; i < songs.Length; i++)
            {
                int remainder = songs[i] % 60;
                if(remainder != 0)//if its not divisible by 60
                {
                    if (remainderDict.ContainsKey(60 - remainder))//determine if there exists a complement that adds to 60
                    {
                        pairCount += remainderDict[60 - remainder];//if complement exists then count each ocurrence of remainder complement
                    }
                }
                else
                {
                    if (remainderDict.ContainsKey(0))//check for multiples of 60, if there are more than 1 then they can be paired up
                    {
                        pairCount += remainderDict[0];//if multiple numbers which are multiples of 60 exist, then we add them to the pairs as they occur, example
                                                      //60, 120 make 2 pairs, 60, 120, 180, 240 make  12 pairs
                    }
                }

                if (remainderDict.ContainsKey(remainder))
                    remainderDict[remainder] += 1;//add ocurrence of number to dictionary
                else
                    remainderDict.Add(remainder, 1);//add to dictionary if its not located
            }
            return pairCount;
        }
    }
}
