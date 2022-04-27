using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Array_Manipulation.FlippingAnImage
{
    class FlippingAnImage
    {
        //Given an n x n binary matrix image, flip the image horizontally, then invert it, and return the resulting image.
        //To flip an image horizontally means that each row of the image is reversed.
        //For example, flipping[1, 1, 0] horizontally results in [0,1,1].
        //To invert an image means that each 0 is replaced by 1, and each 1 is replaced by 0.
        //For example, inverting[0, 1, 1] results in [1,0,0].
        public int[][] FlipAndInvertImage(int[][] image)
        {
            int n = image[0].Length;//get the dimentions of n
            foreach (int[] row in image)//loop through each row
                for (int i = 0; i < (n + 1) / 2; ++i)//we only need to traverse half the array 
                {                                    //since we are reversing it
                    int tmp = row[i] ^ 1;//set a temp variable to be the value at the row in the ith position XOR 1
                    row[i] = row[n - 1 - i] ^ 1;//set the row at i to be the last column of the row XOR 1
                    row[n - 1 - i] = tmp;//swap the temporary
                }

            return image;//return the image
        }
    }
}
