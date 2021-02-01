using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.ShortestWordDistance
{
    public class ShortestWordDistance
    {
        public int ShortestDistance(string[] words, string word1, string word2)
        {
            IDictionary<string, IList<int>> dict = new Dictionary<string, IList<int>>();
            int i = 0;
            foreach(string word in words)
            {
                if (dict.ContainsKey(word)){
                    dict[word].Add(i);
                }
                else
                {
                    dict[word] = new List<int>() { i };
                }
                i++;
            }

            int minDistance = int.MaxValue;

            foreach(int index in dict[word1])
            {
                foreach (int index2 in dict[word1])
                {
                    minDistance = Math.Min(Math.Abs(index - index2), minDistance);
                }
            }

            return minDistance;
        }

        public int ShortestDistance1(string[] words, string word1, string word2)
        {
            int word1Index = -1;
            int word2Index = -1;
            int minDistance = words.Length;

            for(int i = 0; i < words.Length; i++)//linearly pass through array
            {
                if(words[i] == word1)//if we either word, update the index
                {
                    word1Index = i;
                }
                else if(words[i] == word2)
                {
                    word2Index = i;
                }

                if(word1Index != -1 && word2Index != -1)//if we have at least one index for each word
                {
                    minDistance = Math.Min(Math.Abs(word1Index - word2Index), minDistance); //get the minimum of the current minimum distance 
                                                                                            //and the absolute value of the difference of index 1 and 2
                }
            }

            return minDistance;

        }

    }
}
