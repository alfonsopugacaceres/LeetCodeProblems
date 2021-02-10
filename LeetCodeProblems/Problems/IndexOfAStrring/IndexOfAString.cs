using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.IndexOfAStrring
{
    public class IndexOfAString
    {
        class Trie
        {
            public Dictionary<char, Trie> Letters = new Dictionary<char, Trie>();//this creates the paths to all words
            public string Word;

            public void Build(string[] words)//build the trie with all target words we want to find
            {
                Trie root = this;
                foreach (string word in words)//loop through all the target words
                {
                    Trie node = root;//set the node to the root
                    foreach (char letter in word)//loop through the characters of each word
                    {
                        if (node.Letters.ContainsKey(letter))//if the trie contains the current letter
                        {
                            node = node.Letters[letter];//update the node to be the Trie located in the dictionary for that letter
                                                        //this creates the traversal for the word letter by letter
                        }
                        else
                        {
                            Trie temp = new Trie();//otherwise create a new Trie
                            node.Letters.Add(letter, temp);//Add the letter to the dictionary in the Trie with the current Trie
                            node = temp;//update the node
                        }
                    }
                    node.Word = word;//the word in the current Trie is the word we are looping through
                }
            }

            public List<int> Exist(int i, string text)
            {
                var res = new List<int>();
                GetResults(i, text, this, res);
                return res;
            }

            private void GetResults(int i, string text, Trie trie, List<int> indexes)
            {
                if (trie == null)//if the trie is null, just return
                {
                    return;
                }

                if (trie.Word != null)//if the trie has a non null word, add the index to the list (this means the trie node has a full word)
                {
                    indexes.Add(i);
                }

                if (i >= text.Length)//if the current index is larger or equal to the length of the target word, return
                {
                    return;
                }
                if (trie.Letters == null)//if the dictionary containing the letters of the current trie is null, return
                {
                    return;
                }
                if (!trie.Letters.ContainsKey(text[i]))//if you cannot find the current letter at index i of the target word in the Trie, return
                {
                    return;
                }

                Trie node = trie.Letters[text[i]];//hop to the child Trie at the current letter in the dictionary
                node.GetResults(i + 1, text, node, indexes);//repeat the process
            }
        }

        public int[][] IndexPairs(string text, string[] words)
        {
            var root = new Trie();
            root.Build(words);//initializes the Trie to contain our target words

            // Get Result indexes
            var results = new List<List<int>>();
            for (int i = 0; i < text.Length; i++)
            {
                var foundIds = root.Exist(i, text);
                if (foundIds.Count == 0)
                {
                    continue;
                }

                foreach (int item in foundIds)
                {
                    results.Add(new List<int> { i, item - 1 });
                }
            }

            // Parse result to the given data type
            var res = new int[results.Count][];
            for (int i = 0; i < results.Count; i++)
            {
                List<int> item = (List<int>)results[i];
                res[i] = item.ToArray();
            }

            return res;
        }
    }
}
