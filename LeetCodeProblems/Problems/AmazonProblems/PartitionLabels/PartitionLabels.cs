using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LeetCodeProblems.Problems.AmazonProblems.PartitionLabels
{
    public class PartitionLabels
    {
        public PartitionLabels()
        {

        }

        public IList<int> Solve(string s)
        {
            if(s.Length < 1 || s.Length > 500)
            {
                return null;
            }

            IDictionary<char,int> start = new Dictionary<char, int>();
            IDictionary<char, int> end = new Dictionary<char, int>();

            int i = 0;
            foreach(char c in s)
            {
                if (!start.ContainsKey(c))
                {
                    start.Add(c, i);
                    end.Add(c, i);
                }
                else if(end.ContainsKey(c)){
                    end[c] = i;
                }
            }

            HashSet<char> partition = new HashSet<char>();
            IList<int> res = new List<int>();

            foreach (char c in s )
            {
                if (!partition.Contains(c))
                {
                    partition.Add(c);
                }


            }


            return null;

        }
    }
}
