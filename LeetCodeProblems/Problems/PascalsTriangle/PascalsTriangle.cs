using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.PascalsTriangle
{
    public class PascalsTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> pascalsTriangle = new List<IList<int>>();
            if (numRows < 0 || numRows > 30)
                return null;
            if (numRows == 1)
                pascalsTriangle.Add(new List<int>() { 1 });
            else if (numRows == 2)
            {
                pascalsTriangle.Add(new List<int>() { 1 });
                pascalsTriangle.Add(new List<int>() { 1 , 1});
            }
            else
            {
                int counter = 2;
                pascalsTriangle.Add(new List<int>() { 1 });
                pascalsTriangle.Add(new List<int>() { 1, 1 });

                while(numRows > counter)
                {
                    IList<int> previous = pascalsTriangle[counter - 1];
                    pascalsTriangle.Add(new List<int>());
                    int newCounter = pascalsTriangle[counter - 1].Count + 1;
                    int j = 0;
                    pascalsTriangle[counter].Add(1);
                    for (int j = 0; j < previous.Count; j++)
                        pascalsTriangle[counter].Add(previous[j - 1] + previous[j]);

                    pascalsTriangle[counter].Add(1);

                    counter++;
                }
            }
            return pascalsTriangle;
        }
        public IList<IList<int>> Generate1(int numRows)
        {

            List<IList<int>> triangle = new List<IList<int>>();

            // Base case; first row is always [1].
            triangle.Add(new List<int>());
            triangle[0].Add(1);

            for (int rowNum = 1; rowNum < numRows; rowNum++)
            {
                List<int> row = new List<int>();
                IList<int> prevRow = triangle[rowNum - 1];

                // The first row element is always 1.
                row.Add(1);

                // Each triangle element (other than the first and last of each row)
                // is equal to the sum of the elements above-and-to-the-left and
                // above-and-to-the-right.
                for (int j = 1; j < rowNum; j++)
                {
                    row.Add(prevRow[j - 1] + prevRow[j]);
                }

                // The last row element is always 1.
                row.Add(1);

                triangle.Add(row);
            }

            return triangle;
        }
    }
}
