using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.SynonymousSentences
{
    public class SynonymousSentences
    {
        public IList<string> GenerateSentences(IList<IList<string>> synonyms, string text)
        {
            IDictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();
            HashSet<string> ret = new HashSet<string>();

            foreach(IList<string> synonymPair in synonyms)
            {
                UniqueAddToDictList(dict,synonymPair[0]);
                UniqueAddToDictList(dict, synonymPair[1]);
            }

            return null;
        }

        public void GenerateResults(HashSet<int> incidents, IDictionary<string,IList<string>> synonymPairs, string text)
        {
            HashSet<string> s = new HashSet<string>();
            IList<string> splitText = text.Split(' ');

            for(int i = 0; i < splitText.Count; i++)
            {
                if (incidents.Contains(i))
                {

                }
            }
        }

        public HashSet<int> FindIncidentLocations(IDictionary<string,IList<string>> synonymPaths, string text)
        {
            IList<string> splitText = text.Split(' ');
            HashSet<int> incidents = new HashSet<int>();
            int counter = 0;
            string nString = string.Empty;

            foreach(string s in splitText)
            {
                if (synonymPaths.ContainsKey(s))
                {
                    incidents.Add(counter);
                }
                else
                {
                    nString += s;
                }
                counter++;
            }

            return incidents;
        }

        public void UniqueAddToDictList(IDictionary<string,IList<string>> dict, string s)
        {
            if (!dict.ContainsKey(s))
            {
                dict[s] = new List<string>();
            }
            if (dict[s].Contains(s))
            {
                dict[s].Add(s);
            }
        }
    }
}
