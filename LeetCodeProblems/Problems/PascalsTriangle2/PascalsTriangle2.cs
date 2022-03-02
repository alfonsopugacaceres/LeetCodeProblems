using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.PascalsTriangle2
{
    //119. Pascal's Triangle II
    public class PascalsTriangle2
    {
        IList<IList<int>> boundedTriangle;//create a local to store all pascal triable numbers
        public PascalsTriangle2()
        {
            boundedTriangle = new List<IList<int>>();//create the list
            boundedTriangle.Add(new List<int>() { 1 });//add the initial case
            for(int i = 1; i <= 33; i++)//loop through all bounded posibilities
            {
                IList<int> prev = boundedTriangle[i - 1];//reference the previous one
                boundedTriangle.Add(new List<int>() { 1 });//instantiate the list, add the initial case
                for (int j = 1; j < prev.Count; j++)//loop through all members in the previous list to accumulate the values
                    boundedTriangle[i].Add(prev[j] + prev[j-1]);//add the accumulation to the new bounded triangle
                boundedTriangle[i].Add(1);//add the final case
            }
        }
        public IList<int> GetRow(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex > 33)//edge case
                return null;
            else
            {
                return boundedTriangle[rowIndex];//call our memonized bounded triablge
            }
        }
        public IList<int> GetRow2(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex > 33)//check for edge case
                return null;
            else
            {
                if (rowIndex == 0)//initial case
                    return new List<int>() { 1 };
                else
                {
                    IList<int> prev = new List<int>() { 1 };//create the previous, which is the initial state
                    for (int i = 1; i <= rowIndex; i++)//loop until we get the right index
                    {
                        IList<int> current = new List<int>() { 1 };//add the initial case for all pascals triangles
                        for (int j = 1; j < i; j++)//loop through the previous members 
                        {
                            current.Add(prev[j - 1] + prev[j]);//add them up, add them to the current list
                        }
                        current.Add(1);//add the end case
                        prev = current;//advance the previous to be the current created list
                    }
                    return prev;//return previous, which is the current created list by the end of the loop
                }
            }
        }
    }
}
