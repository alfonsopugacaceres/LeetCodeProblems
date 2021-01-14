using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.AlphabetBoardPath
{
    public class AlphabetBoardPath
    {

        public string AlphabetB(string target)
        {
            char[][] alphaBoard = new char[6][];
            alphaBoard[0] = new char[5];
            alphaBoard[1] = new char[5];
            alphaBoard[2] = new char[5];
            alphaBoard[3] = new char[5];
            alphaBoard[4] = new char[5];
            alphaBoard[5] = new char[1];
            char cur = 'a';
            string ret = string.Empty;

            for(int i = 0; i < alphaBoard.Length; i++)
            {
                for(int j = 0; j < alphaBoard[i].Length; j++)
                {
                    alphaBoard[i][j] = cur;
                    cur++;
                }
            }

            int iTraversal = 0;
            int jTraversal = 0;
            foreach (char c in target)
            {
                ret += Traversal(c, alphaBoard, ref iTraversal, ref jTraversal);
            }

            return ret;
        }

        public string Traversal(char target, char[][] alphaBoard, ref int i, ref int j)
        {
            if(target == alphaBoard[i][j])
            {
                return "!";
            }
            else if (i < alphaBoard.Length && alphaBoard[i + 1][j] < target)
            {
                i++;
                return "U" + Traversal(target, alphaBoard, ref i, ref j);
            }
            else if (j < alphaBoard[i].Length && alphaBoard[i][j + 1] > target)
            {
                j++;
                return "R" + Traversal(target, alphaBoard, ref i, ref j);
            }
            else if (i > 0 && alphaBoard[i - 1][j] > target)
            {
                i--;
                return "D" + Traversal(target, alphaBoard, ref i, ref j);
            }
            else if (j > 0 && alphaBoard[i][j - 1] < target)
            {
                j--;
                return "L" + Traversal(target, alphaBoard, ref i, ref j);
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
