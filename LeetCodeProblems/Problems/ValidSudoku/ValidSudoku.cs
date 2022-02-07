using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.ValidSudoku
{
    //36. Valid Sudoku
    //Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:
    public class ValidSudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            if(board.Length != 9)
            {
                return false;
            }
            else
            {
                for(int i = 0; i < board.Length; i++)
                {
                    if (board[i].Length != 9)
                        return false;
                }

                bool valid = true;
                valid = (IsValid(board, 0, 0)) ? true : false;
                valid = (IsValid(board, 0, 3)) ? true : false;
                valid = (IsValid(board, 0, 6)) ? true : false;
                valid = (IsValid(board, 3, 0)) ? true : false;
                valid = (IsValid(board, 3, 4)) ? true : false;
                valid = (IsValid(board, 3, 6)) ? true : false;
                valid = (IsValid(board, 6, 0)) ? true : false;
                valid = (IsValid(board, 6, 3)) ? true : false;
                valid = (IsValid(board, 6, 6)) ? true : false;
                return valid;
            }
        }

        public bool IsValid(char[][] threexboard, int iStart, int jStart)
        {
            HashSet<int> hashset = new HashSet<int>();
            int xBound = iStart + 2;
            int yBound = jStart + 2;
            for(int i = iStart; i < xBound; i++)
            {
                for(int j = jStart; j < yBound; j++)
                {
                    if(threexboard[i][j] == '.')
                    {
                        continue;
                    }
                    else 
                    {
                        int curNum = (int)threexboard[i][j];
                        if ((curNum < 1 || curNum > 9) || hashset.Contains(curNum))
                            return false;
                    }
                }
            }
            return true;
        }
    }
}
