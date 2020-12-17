using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.CountSubmatricesAllOnes
{
    public class CountSubMatricesAllOnes
    {



        //Excample matrix
        //  0 0 1 1
        //  1 0 1 1
        //  0 1 0 1
        //  1 1 1 0
        // 
        // Our vertical accumulation works like this, as we look through the rows, we accumulate based on previous values
        // when i = 0
        //  0 0 1 1
        // when i = 1
        //  1 0 2 2
        // when i = 2
        //  0 1 0 3
        // when i = 3
        //  1 2 1 0
        //


        public int NumSubmat(int[][] mat)
        {
            int[] verticalAccumulation = new int[mat[0].Length];//create an array to store all verical acculumation of 1s

            int totalSum = 0;
            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    if (mat[i][j] > 0)
                    {
                        verticalAccumulation[j]++;//use the vertical infed to store the current count, since we found a 1, we increase once
                        totalSum += verticalAccumulation[j]; //add the current count to the total sum
                        int minUntilInRow = verticalAccumulation[j];//use the current vertical count as the minimum
                        int k = j - 1;//create a separate counter starting at j - 1 
                        while (k >= 0 && mat[i][k] > 0)
                        {
                            minUntilInRow = Math.Min(minUntilInRow, verticalAccumulation[k]);//check the vertical accumulation at k to check for possible extra 1s
                            totalSum += minUntilInRow;//add it to the total sum
                            k--;//go up a layer to check the previous count
                        }
                    }
                    else
                    {
                        verticalAccumulation[j] = 0;
                    }
                }
            }
            return totalSum;
        }





    }
}
