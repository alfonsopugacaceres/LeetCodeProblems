using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.FlippingAnImage
{
    public class FlippingAnImage
    {
        //832. Flipping an Image
        public int[][] FlipAndInvertImage(int[][] image)
        {

            for(int i = 0; i < image.Length; i++)
            {
                for(int j = 0, k = image.Length-1; j <= k; j++, k++)
                {
                    int temp = image[i][j];
                    image[i][j] = (image[i][k] ==1) ? 0 : 1;
                    image[i][k] = (temp == 1) ? 0 : 1;
                }
            }
            return image;
        }

    }
}
