using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.CountSquareSubmatricies
{
    public class CountSquareSubmatricies
    {
        public int CountSquares(int[][] matrix)
        {
            if(matrix.Length < 1 || matrix.Length > 300)
            {
                return -1;
            }
            else
            {
                int squareMatricCount = 0;
                IDictionary<int, int> dict = new Dictionary<int, int>();

                //we are using the i,j as the bottom corner to specify how to count the squares
                //1 1
                //1 1 <--------------------- This is the corner
                //0 1 0 1
                //1 1 0 0 
                //1 1 1 1 
                //0 0 1 1<----------------------------This is the corner
                //there are three main cases,
                // case matrix[i][j] == 0
                // case matrix[]i[j] == 1 
                for(int i = 0; i < matrix.Length; i++)
                {
                    for(int j = 0; j < matrix[i].Length; j++)
                    {
                        if(matrix[i][j] == 0)
                        {
                            continue;
                        }
                        else if(i == 0 || j == 0)
                        {
                            squareMatricCount++;
                            continue;
                        }
                        else
                        {
                            int min = Math.Min(matrix[i - 1][j - 1],//diagonal
                                                Math.Min(matrix[i][j - 1],//left
                                                matrix[i - 1][j]));//top
                            matrix[i][j] += min;
                            squareMatricCount += matrix[i][j];
                        }
                    }
                }
                return squareMatricCount;
            }
        }

    }
}
