using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LeetCodeProblems.Problems.AmazonProblems.BannedWords
{
    public class BannedWords
    {
        public BannedWords()
        {

        }

        public string MostCommonWord(string paragraph, string[] banned)
        {
            if(paragraph.Length < 1 || paragraph.Length > 1000)
            {
                return null;
            }
            if(banned.Length < 0 || banned.Length > 100)
            {
                return null;
            }

            IDictionary<string, int> dict = new Dictionary<string, int>();
            HashSet<string> bannedHash = new HashSet<string>();
            int max = 0;
            string maxword = string.Empty;
            foreach(string x in banned)
            {
                bannedHash.Add(x);
            }

            string cleanParagraph = string.Empty;
            foreach(char x in paragraph)
            {
                if(x == '!' || x == '?' || x == ',' || x == ';' || x == '.' || x == '\'')
                {
                    cleanParagraph += " ";
                }
                else if(x >= 65 && x <= 90)
                {
                    cleanParagraph += char.ToLower(x);
                }
                else
                {
                    cleanParagraph += x;
                }
            }
            cleanParagraph = Regex.Replace(cleanParagraph, @"\s+", " ");
            string[] words = cleanParagraph.Split(" ");

            foreach(string word in words)
            {
                if (bannedHash.Contains(word))
                {
                    continue;
                }
                else
                {
                    if (dict.ContainsKey(word))
                    {
                        dict[word] = 1 + dict[word];
                        if (dict[word] > max)
                        {
                            max = dict[word];
                            maxword = word;
                        }
                    }
                    else
                    {
                        dict[word] = 1;
                        if (max == 0)
                        {
                            max = 1;
                            maxword = word;
                        }
                    }
                }
            }


            return maxword;
        }
    }
}
