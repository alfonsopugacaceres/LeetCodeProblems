using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.DynamicProgrammingTabulation.FindWinnerOnTicTacToe
{
    class TicTacToeWinner
    {
        /// <summary>
        /// This questions is all about accumulating moves and then evaluating to determine if someone actually won
        /// 4 cases
        /// Pending Game, nobody has won yet, and there are not enough moves to be stuck
        /// Draw Game, nobody won and there are no more moves available
        /// Winner A / B, happens when somebody gets 3 in a row in a column, row or diagonal
        /// create an array of rows, an array of columns and 2 diagonal variables to accumulate the moves on each one
        /// tag player A with a +1 and player B with a -1
        /// if any slot in column, or any slot in row, or any of the two diagonals reaches 3 or -3
        /// then you know there is a winner, so return the answer
        /// </summary>
        /// <param name="moves"></param>
        /// <returns></returns>
        public string Tictactoe(int[][] moves)
        {
            int[] rows = new int[3];//storage for row accumulation
            int[] cols = new int[3];//storage for column accumulation
            int diag1 = 0;//storage for first diagonal
            int diag2 = 0;//storage for second diagonal



            bool playerA = true;//flag to flip the tag
            int counter = 0;//counter to compare if the game is pending
            foreach (int[] move in moves)
            {
                int tag = (playerA) ? 1 : -1;//set the tag
                rows[move[0]] += tag;//set the row accumulation
                cols[move[1]] += tag;//set the column accumulation
                if (move[0] == 0 && move[1] == 0 ||
                   move[0] == 2 && move[1] == 2 ||
                   move[0] == 1 && move[1] == 1
                  )
                {
                    diag1 += tag;//set the first diagonal accumulation
                }
                if (move[0] == 0 && move[1] == 2 ||
                   move[0] == 2 && move[1] == 0 ||
                   move[0] == 1 && move[1] == 1
                  )
                {
                    diag2 += tag;//set the second diagonal accumulation
                }
                playerA = !playerA;//flip the player
                counter++;//add to the counter
            }

            string ret = string.Empty;
            for (int i = 0; i < rows.Length; i++)//loop the rows and try to find a winner
            {
                if (rows[i] == 3)
                    return ret = "A";
                if (rows[i] == -3)
                    return ret = "B";
            }
            for (int i = 0; i < cols.Length; i++)//loop the columns and try to find a winner
            {
                if (cols[i] == 3)
                    return ret = "A";
                if (cols[i] == -3)
                    return ret = "B";
            }
            if (diag1 == 3 || diag2 == 3)//check the diagonal1 for a winner
                return ret = "A";
            if (diag1 == -3 || diag2 == -3)//check the diagonal2 for a winner
                return ret = "B";

            if (counter >= 9)//check if there are more moves to be made, if there are not its a draw, otherwise pending
                return "Draw";
            else
                return "Pending";


        }
    }
}
