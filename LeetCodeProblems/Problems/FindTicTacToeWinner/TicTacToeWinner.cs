using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.FindTicTacToeWinner
{
    public class TicTacToeWinner
    {
        public string Tictactoe(int[][] moves)
        {
            int[,] grid = new int[3, 3];
            bool isX = true;
            foreach (int[] move in moves)
            {
                grid[move[0], move[1]] = (isX) ? 'X' : 'O';
                isX = !isX;
            }
        }

        public bool CheckWinner(int[,]grid, int[] latestMove)
        {
            if()
        }
    }
}
