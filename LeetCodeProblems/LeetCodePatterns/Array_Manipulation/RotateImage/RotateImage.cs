using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Array_Manipulation.RotateImage
{
    class RotateImage
    {
        public void Rotate(int[][] matrix)
        {
            int top = 0;
            int left = 0;
            int right = matrix[0].Length - 1;
            int bottom = matrix.Length - 1;


            while (left < right)
            {

                for (int i = 0; i < right - left; i++)
                {

                    //save the top left value in storage
                    int storage = matrix[top][left + i];

                    //move bottom left into top left
                    matrix[top][left + i] = matrix[bottom - i][left];

                    //move bottom right into bottom left
                    matrix[bottom - i][left] = matrix[bottom][right - i];

                    //move right into bottom right
                    matrix[bottom][right - i] = matrix[top + i][right];

                    //move top left into top right
                    matrix[top + i][right] = storage;
                }

                left++;
                right--;
                top++;
                bottom--;
            }
        }
    }
}
