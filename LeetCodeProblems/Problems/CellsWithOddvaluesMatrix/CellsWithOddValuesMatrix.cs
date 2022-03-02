using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.CellsWithOddvaluesMatrix
{
    public class CellsWithOddValuesMatrix
    {
        public int OddCells(int m, int n, int[][] indices)
        {
            if (m < 1 || n > 50)//check for edge cases
                return -1;
            else if (indices.Length < 1 || indices.Length > 100)//check for edge cases
                return -1;
            else
            {
                int[,] matrix = new int[m, n];//create a matrix
                int oddNumbers = 0;//create result variable

                for (int i = 0; i < indices.Length; i++)
                {
                    int incrementor = 0;
                    while (incrementor < n)//loop through all columns in the given row and increment all values by 1
                    {
                        matrix[indices[i][0], incrementor]++;
                        if (matrix[indices[i][0], incrementor] % 2 == 1)//increment the odd numbers if its odd
                            oddNumbers++;
                        else
                            oddNumbers--;//decrement the odd numbers if its even
                        incrementor++;//advance the counter
                    }
                    incrementor = 0;
                    while (incrementor < m)//loop through all rows in the given column and increment all values by 1
                    {
                        matrix[incrementor, indices[i][1]]++;
                        if (matrix[incrementor, indices[i][1]] % 2 == 1)//increment the odd numbers if its odd
                            oddNumbers++;
                        else
                            oddNumbers--;//decrement the odd numbers if its even
                        incrementor++;//advance the counter
                    }
                }

                return oddNumbers;//return the answer
            }
        }
        public int OddCells2(int m, int n, int[][] indices)
        {
            if (m < 1 || n > 50)//check for edge cases
                return -1;
            else if (indices.Length < 1 || indices.Length > 100)//check for edge cases
                return -1;
            else
            {
                int count = 0;
                int[] row = new int[m];//create an array to keep track of rows
                int[] col = new int[n];//create an array to keep track of columns
                foreach (int[] x in indices)//loop through all index pairs
                {
                    row[x[0]]++;//increment the respective row 
                    col[x[1]]++;//increment the respective column
                }

                //loop through all rows and columns
                for (int i = 0; i < m; i++)
                    for (int j = 0; j < n; j++)
                    {
                        if ((row[i] + col[j]) % 2 != 0)//if the number of times a particular slot was touched by an increment operation from either
                            count++;                   //adding 1 by rows or adding 1 by columns modulo two is not 0, then the number is odd
                    }
                return count;//return the count

            }

        }
    }
}
