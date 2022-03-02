using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.DivisorGame
{
    //1025. Divisor Game
    public class DivisorGame
    {
        public bool DivisorGamefunc(int n)
        {
            if (n < 1 || n > 1000)//edge cases
                return false;
            else
            {
                bool isAlice = true;//boolean that represents if its alice, start negative since the first time is always alice (and we flip it in the loop)
                int x = 1;//the optimal move is always to do 1

                while (n > 1)//while n > 1
                {
                    n = n - x;//perform operation
                    isAlice = !isAlice;//flip the alice flag
                }
                return isAlice;//return if its alice
            }
        }
    }
}
