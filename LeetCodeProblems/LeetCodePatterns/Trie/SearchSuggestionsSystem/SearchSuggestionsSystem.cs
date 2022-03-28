using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Trie.SearchSuggestionsSystem
{
    class SearchSuggestionsSystem
    {

        //tags Amazon

        //1268. Search Suggestions System

        //You are given an array of strings products and a string searchWord.
        //Design a system that suggests at most three product names from products after each character of 
        //searchWord is typed.Suggested products should have common prefix with searchWord. If there are more 
        //than three products with a common prefix return the three lexicographically minimums products.
        //Return a list of lists of the suggested products after each character of searchWord is typed.

        /// <summary>
        /// TrieNode class, a trie is a data structure to efficiently traverse trough multiple sets of words by creating
        /// a sort of hashing mechanism.
        /// </summary>
        public class TrieNode
        {
            public TrieNode[] FollowUps { get; set; }//These are the follow ups to your current trie, a collection
                                                     //of all the 26 letters of the alphabet
            public bool IsWord { get; set; }//this flag lets us know if the collection of letters up to now 
                                            //is a word previously entered
            public char Value { get; set; }//this is the current value of the node in the trie

            public TrieNode(char val)
            {
                this.Value = val;//this is the value of the current trie node
                this.FollowUps = new TrieNode[26];//only 26 letters in the alphabet
                this.IsWord = false;//flag for having found a word
            }

        }

        /// <summary>
        /// this function is in charge of enforcing the rules of the trie. We loop through each character and
        /// we add it to the traversal of follow ups to make sure each letter is instatiated as a separate trie
        /// </summary>
        /// <param name="s">string to be parsed through</param>
        /// <param name="root">root of the trie</param>
        public void Insert(string s, TrieNode root)
        {
            TrieNode current = root;

            foreach (char c in s)//foreach character in the string
            {
                //notice, we are using the -'a' to turn a lowercase alpha character into an index from 0 to 25
                if (current.FollowUps[c - 'a'] == null)//check if the followup is already instantiated
                    current.FollowUps[c - 'a'] = new TrieNode(c);//if it isn't just instantiate it
                current = current.FollowUps[c - 'a'];//move the current traversal up to the next follow up
            }

            current.IsWord = true;//at the end of the foreach, you know the current now is a word. Tag it as a word

        }
        
        /// <summary>
        /// using a word bank of words, we initialize the trie. Notice the root node
        /// has a space as its value. To populate the trie all we have to do is call the 
        /// insert function for each work at the root iteratively 
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public TrieNode BuildTrie(string[] words)
        {
            TrieNode root = new TrieNode(' ');
            foreach (string word in words)//insert each word in the trie
            {
                Insert(word, root);
            }

            return root;//return the root
        }

        /// <summary>
        /// The find top function uses a trie root and a search word to find the top x 
        /// candidates of products that could be being searched for. 
        /// </summary>
        /// <param name="root">root of the trie to traverse</param>
        /// <param name="searchWord">word to search for int he trie</param>
        /// <param name="FindTop">how many results we want</param>
        /// <returns></returns>
        IList<string> FindTop(TrieNode root, string searchWord, int FindTop)
        {
            IList<string> res = new List<string>();//this is the result list
            TrieNode traversal = root;//set the traversal to the root

            foreach (char c in searchWord)//foreach character in the search word
            {
                if (traversal.FollowUps[c - 'a'] == null)//check if there are any follow ups, if there is not
                    return res;                          //then just return what we have right now
                else
                    traversal = traversal.FollowUps[c - 'a'];//otherwise, advance the traversal
            }


            if (traversal.IsWord)//after we are done with the traversal of the search word, we need to check
                res.Add(searchWord);//if we already found a product at the end of the search word, if we did
                                    //just add it to the list

            foreach (TrieNode followup in traversal.FollowUps)//we use a foreach on our follow ups at the current traversal
            {                                                 //to see if we can find some more products to add to the list
                if (followup != null)//as long as the follow up is not null
                {
                    dfs(followup, searchWord, res, FindTop);//run the deph first search to add items to the list
                    if (res.Count >= FindTop)//if we ever are larger than or equal to the top number of products we want
                        return res;//return the answer
                }
            }

            return res;

        }

        /// <summary>
        /// This depth first search tries to find total product names in our trie traversal. We only
        /// care about the top x products
        /// </summary>
        /// <param name="root">root of the trie</param>
        /// <param name="word">word we are searching for</param>
        /// <param name="result">list holding our result of found products</param>
        /// <param name="top">how many products we want</param>
        /// <returns></returns>
        public IList<string> dfs(TrieNode root, string word, IList<string> result, int top)
        {
            if (result.Count == 3)//if we already have "top" results just return the result
                return result;
            if (root.IsWord)//if the current root is a word, add it to the result
            {
                result.Add(word + root.Value);//add to the result
                if (result.Count >= top)//once again check if we have top results
                    return result;//if we do just return out
            }

            foreach (TrieNode folloup in root.FollowUps)//otherwise we iteratively run the dfs on all our follow ups
            {                                           //this allows us to keep the lexiographic condition intact
                if (folloup != null)//we keep processing as long as the follow up is not a null
                    dfs(folloup, word + root.Value, result, top);//notice we are adding our current root val to the word,
                                                                 //each trie only has one word, so to have the actual name 
                                                                 //of the product we have to keep updating the word passed down
            }
            return result;//at the end we just return what we have
        }

        /// <summary>
        /// The purpose of this function is to suggest the names of the top 3 most possible products given a string 
        /// being typed. As the user types the string we use prefixes and our trie to find the most likely 3 products
        /// they are searching for
        /// </summary>
        /// <param name="products">products they could possibly be searching for</param>
        /// <param name="searchWord">the string they are typing</param>
        /// <returns></returns>
        public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            TrieNode root = BuildTrie(products);//build the trie and capture the root
            IList<IList<string>> result = new List<IList<string>>();//this is our result variable

            for (int i = 1; i <= searchWord.Length; i++)//loop starting at 1, because we need at least 1 char to 
            {                                           //make a substring
                result.Add(FindTop(root, searchWord.Substring(0, i), 3));//call our function find top and add it to
                                                                         //the result
            }

            return result;//return the result
        }
    }
}