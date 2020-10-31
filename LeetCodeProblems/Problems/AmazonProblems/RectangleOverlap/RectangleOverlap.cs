using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.AmazonProblems.RectangleOverlap
{
    public class RectangleOverlap
    {
        public bool IsRectangleOverlap(int[] rec1, int[] rec2)
        {
            if(rec1 == null || rec2 == null || rec1.Length != 4 || rec2.Length != 4)
            {
                return false;
            }
            else if (rec1[0] < -1000000000 || rec1[0] > 1000000000 || 
                rec1[1] < -1000000000 || rec1[1] > 1000000000 || 
                rec1[2] < -1000000000 || rec1[2] > 1000000000 || 
                rec1[3] < -1000000000 || rec1[3] > 1000000000 || 
                rec2[0] < -1000000000 || rec2[0] > 1000000000 ||
                rec2[1] < -1000000000 || rec2[1] > 1000000000 ||
                rec2[2] < -1000000000 || rec2[2] > 1000000000 ||
                rec2[3] < -1000000000 || rec2[3] > 1000000000 )
            {
                return false;
            }
            else
            {
                // rec1 and rec 2 both contain 4 coordinates.
                //coordinates at slot 2 and 3 contain the top right and 0 and 1 contain bottom left.
                //to determine if our rectangles intersect we can check if the top right coordinate is below 
                //the bottom left coordinate or check if the bottom left coordinate is to the left of the 
                //top right coordinate. This will let us know if the rectangles overlapped
                return (
                    rec1[0] < rec2[2] &&
                    rec2[0] < rec1[2] &&
                    rec1[1] < rec2[3] && 
                    rec2[1] < rec1[3]);
            }
        }
    }
}
