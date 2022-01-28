using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.PerformStringShifts
{
    public class StringShifts
    {
        //1427. Perform String Shifts
        public string StringShift(string s, int[][] shift)
        {
            string shifted = s;
            for (int i = 0; i < shift.Length; i++)
            {
                bool isRightShift = (shift[i][0] == 1);
                int shiftTimes = shift[i][1];

                if (isRightShift)
                {
                    shifted = shifted.Substring(shifted.Length - shiftTimes, shiftTimes) + shifted.Substring(0, shifted.Length - shiftTimes);
                }
                else
                {
                    shifted = shifted.Substring(0 + shiftTimes, shifted.Length - shiftTimes) + shifted.Substring(0, shiftTimes);
                }
            }

            return shifted;
        }
    }
}
