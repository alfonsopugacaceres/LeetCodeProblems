using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Array_Manipulation.SetMatrixZeroes
{
    class SetMatrixZeroes
    {
        public void SetZeroes(int[][] matrix)
        {

            int col0 = 1;

            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i][0] == 0)
                    col0 = 0;
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 1; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        matrix[0][j] = 0;//set the row to 0
                        matrix[i][0] = 0;//set the col to 0
                    }
                }
            }

            for (int i = 1; i < matrix[0].Length; i++)
            {
                if (matrix[0][i] == 0)
                {
                    for (int j = 0; j < matrix.Length; j++)
                        matrix[j][i] = 0;
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i][0] == 0)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                        matrix[i][j] = 0;
                }
            }

            if (col0 == 0)
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    matrix[i][0] = 0;
                }
            }

        }
    }
}
