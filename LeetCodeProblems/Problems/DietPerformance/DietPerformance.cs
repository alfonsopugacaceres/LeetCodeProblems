using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.AmazonProblems.DietPerformance
{
    public class DietPerformance
    {
        public int DietPlanPerformance(int[] calories, int k, int lower, int upper)
        {
            if(k < 1 || calories.Length < k || calories.Length > 100000 || lower < 0 || upper < lower || upper < 0)
            {
                return 0;
            }
            else
            {
                int score = 0;
                int currentSize = calories.Length;
                int movingStart = 0;


                for(int i = 0; i < calories.Length; i++)
                {
                    int[] subArray = null;
                    int subArrayCal = 0;
                    if (i + k > calories.Length)
                    {
                        return score;
                    }
                    else
                    {
                        subArray = new int[k];
                        Array.Copy(calories, i, subArray, 0, k);
                        for (int j = 0; j < subArray.Length; j++)
                        {
                            subArrayCal += subArray[j];
                        }
                        if (subArrayCal < lower)
                        {
                            score--;
                        }
                        else if (subArrayCal > upper)
                        {
                            score++;
                        }
                    }
                }
                return score;
            }

        }

    }
}
//while (currentSize >= 0)
//{
//    int[] subArray = null;
//    int subArrayCal = 0;
//    if (currentSize - k <= 0)
//    {
//        for (int i = movingStart; i < calories.Length; i++)
//        {
//            subArrayCal += calories[i];
//        }

//        if (subArrayCal < lower)
//        {
//            score--;
//        }
//        else if (subArrayCal > upper)
//        {
//            score++;
//        }
//        return score;
//    }
//    else
//    {
//        subArray = new int[k];
//        Array.Copy(calories, movingStart, subArray, 0, k);
//        for (int i = 0; i < k; i++)
//        {
//            subArrayCal += subArray[i];
//        }
//        if (subArrayCal < lower)
//        {
//            score--;
//        }
//        else if (subArrayCal > upper)
//        {
//            score++;
//        }
//        movingStart += k;
//        currentSize -= k;
//    }
//}