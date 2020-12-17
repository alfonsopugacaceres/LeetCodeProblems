using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.Problems.LongestStringchain
{
    public class LongestStringchain
    {
        public int LongestStrChain(string[] words)
        {
            IDictionary<string, int> chainLength = new Dictionary<string, int>();//keep a dictionary of all lengths based on word so we can pick the largest
            SortedList<int, HashSet<string>> wordsByLength = new SortedList<int, HashSet<string>>();//dictionary based on word length and keeping a hashset of all words with that length
                                                                                                    //a sorted list is a dictionary which stores keys in a sorted way

            for(int i = 0; i < words.Length; i++)//populate the dictionaries
            {
                if (wordsByLength.ContainsKey(words[i].Length))
                {
                    wordsByLength[words[i].Length].Add(words[i]);
                }
                else
                {
                    wordsByLength[words[i].Length] = new HashSet<string>();
                    wordsByLength[words[i].Length].Add(words[i]);
                }
                chainLength[words[i]] = 1;
            }

            foreach (int wordLen in wordsByLength.Keys.Reverse())//start from the largest value
                if (wordsByLength.ContainsKey(wordLen - 1))//check if the dictionary contains words with the the current key -1
                    foreach (var word in wordsByLength[wordLen])//loop through all the words with the target length
                        for (int i = 0; i < wordLen; i++)//loop through all the characters in the word 
                        {
                            var word2 = word.Remove(i, 1);//remove 1 character from the word, whichever is in the current index
                            if (chainLength.ContainsKey(word2) && //using the chain dictionary check the length of the created word after character deletion
                                chainLength[word] + 1 > chainLength[word2])//check if the current word + 1 has a longer chain than word 2
                            {
                                chainLength[word2] = chainLength[word] + 1;//set the new word's chain count to the chain of the first + 1
                            }
                        }
            return chainLength.Values.Max();
        }
    }
}
