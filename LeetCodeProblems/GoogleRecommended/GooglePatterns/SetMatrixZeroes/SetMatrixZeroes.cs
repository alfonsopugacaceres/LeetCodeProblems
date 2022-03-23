using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.GoogleRecommended.GooglePatterns.SetMatrixZeroes
{
    class SetMatrixZeroes
    {
        public void SetZeroes1(int[][] matrix)
        {
            if (matrix == null)
                return;

            int[] columns = new int[matrix[0].Length];
            int[] rows = new int[matrix.Length];

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        columns[j] = 1;
                        rows[i] = 1;
                    }
                }
            }
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (columns[j] == 1)
                        matrix[i][j] = 0;
                    if (rows[i] == 1)
                        matrix[i][j] = 0;
                }
            }

            return;
        }
    }
}
