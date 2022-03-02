using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeProblems.Problems.RearrangeSpacesBetweenWords
{
    public class RearrangeSpacesBetweenWords
    {
        public string ReorderSpaces(string text)
        {
            decimal spaces = 0;
            IList<string> words = new List<string>();

            string temp = string.Empty;
            foreach(char c in text)
            {

                if (c == ' ')
                {
                    spaces++;
                    if (temp != string.Empty)
                        words.Add(temp);
                    temp = string.Empty;
                }
                else
                    temp += c;
            }

            if (words.Count <= 0)
                return string.Empty;
            else
            {
                int leftoverSpaces = (int)spaces % (words.Count - 1);
                int spacesBetweenWords = (int)Math.Floor(spaces % (words.Count -1));
                string spacesBetweenWordsString = string.Empty;
                for (int i = 0; i < spacesBetweenWords; i++)
                    spacesBetweenWordsString += ' ';
                StringBuilder ret = new StringBuilder();
                foreach(string word in words)
                {
                    ret.Append(word);
                    ret.Append(spacesBetweenWordsString);
                }
                while(leftoverSpaces > 0)
                {
                    ret.Append(' ');
                    leftoverSpaces--;
                }
                return ret.ToString();

            }
        }

    }
}
