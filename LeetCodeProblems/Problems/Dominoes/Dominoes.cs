using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.AmazonProblems.Dominoes
{
    public class Dominoes
    {
        public int NumEquivDominoPairs(int[][] dominoes)
        {
            int result = 0;
            if(dominoes.Length < 1 | dominoes.Length > 40000)
            {
                return result;
            }
            else
            {
                HashSet<Tuple<int,int>> abcd = new HashSet<Tuple<int, int>>();
                HashSet<Tuple<int, int>> abdc = new HashSet<Tuple<int, int>>();
                for (int i = 0; i < dominoes.Length; i++)
                {
                    int x = dominoes[i][0];
                    int y = dominoes[i][1];
                    Tuple<int, int> abcdtry = new Tuple<int, int>(x, y);
                    Tuple<int, int> abdctry = new Tuple<int, int>(y, x);
                    if (abcd.Contains(abcdtry) || abcd.Contains(abdctry) || abdc.Contains(abdctry) || abdc.Contains(abcdtry))
                    {
                        result++;
                    }
                    if(!abcd.Contains(abcdtry))
                        abcd.Add(abcdtry);
                    if (!abdc.Contains(abdctry))
                        abdc.Add(abdctry);
                }
                return result;
            }

        }

        //public bool DominoEquivalency(int a, int b, int c, int d)
        //{
        //    return (a == c && b == d) || (a == d && b == c);
        //}
    }
}
