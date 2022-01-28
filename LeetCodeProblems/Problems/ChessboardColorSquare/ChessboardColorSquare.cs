using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.ChessboardColorSquare
{
    //1812. Determine Color of a Chessboard Square
    public class ChessboardColorSquare
    {
        public bool SquareIsWhite(string coordinates)
        {
            if (coordinates.Length != 2)
                return false;
            else
            {
                char charCoordinate = coordinates[0];
                Console.WriteLine(charCoordinate);
                int index = Convert.ToInt32(coordinates[1]);
                int remainder = index % 2;

                if (charCoordinate == 'a' || charCoordinate == 'c' || charCoordinate == 'e' || charCoordinate == 'g')
                {
                    return (remainder == 0) ? true : false;
                }
                else
                {
                    return (remainder == 0) ? false : true;
                }
            }
        }
        public bool SquareIsWhiteOpt(string coordinates)
        {
            return coordinates[0] % 2 != coordinates[1] % 2;
        }
    }
}
