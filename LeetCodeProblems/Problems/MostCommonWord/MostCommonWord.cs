using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.Problems.MostCommonWord
{
    //819. Most Common Word
    public class MostCommonWord
    {
        public string MostCommonWordF(string paragraph, string[] banned)
        {

            IDictionary<string, int> dict = new Dictionary<string, int>();
            HashSet<string> bannedDict = new HashSet<string>();
            int maxOcurrence = 0;
            string maxString = string.Empty;
            bool prevSeparator = false;

            string cleanParagraph = string.Empty;

            foreach (char c in paragraph)
            {
                if ((c >= 65 && c <= 90))
                {
                    cleanParagraph += Char.ToLower(c);
                    prevSeparator = false;
                }
                else if ((c == '.' || c == ' ' || c == ',' || c == '!' || c == '?' || c == ';' || c == '\''))
                {
                    if (prevSeparator)
                    {
                        continue;//don't double count separators
                    }
                    else
                    {
                        cleanParagraph += '_';
                        prevSeparator = true;
                    }
                }
                else
                {
                    cleanParagraph += c;
                    prevSeparator = false;
                }
            }

            foreach (string banWord in banned)
            {
                bannedDict.Add(banWord);
            }

            IList<string> splitString = cleanParagraph.Split('_');

            foreach (string word in splitString)
            {
                Console.WriteLine("{0}", word);
                if (word == string.Empty)
                {
                    continue;
                }
                if (dict.ContainsKey(word))
                {
                    dict[word]++;
                }
                else
                {
                    dict[word] = 1;
                }

                if (!bannedDict.Contains(word))
                {
                    if (maxOcurrence < dict[word])
                    {
                        maxOcurrence = dict[word];
                        maxString = word;
                    }
                }
            }

            return maxString;
        }
    }
}
