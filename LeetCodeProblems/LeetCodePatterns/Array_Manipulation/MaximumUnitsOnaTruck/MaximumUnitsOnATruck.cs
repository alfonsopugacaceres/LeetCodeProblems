using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Array_Manipulation.MaximumUnitsOnaTruck
{
    class MaximumUnitsOnATruck
    {
        //1710. Maximum Units on a Truck

        //You are assigned to put some amount of boxes onto one truck.You are given a 2D array boxTypes, 
        //where boxTypes[i] = [numberOfBoxesi, numberOfUnitsPerBoxi]:
        //numberOfBoxesi is the number of boxes of type i.
        //numberOfUnitsPerBoxi is the number of units in each box of the type i.
        //You are also given an integer truckSize, which is the maximum number of boxes that can be put on 
        //the truck. You can choose any boxes to put on the truck as long as the number of boxes does not exceed truckSize.
        //Return the maximum total number of units that can be put on the truck.
        public int MaximumUnits(int[][] boxTypes, int truckSize)
        {
            boxTypes = boxTypes.OrderByDescending(f => f[1]).ToArray();//start by sorting the array by the amount of units each box type has
            int counter = 0;//counter variable
            int maxLoad = 0;//maxload 
            while (counter < boxTypes.Length && truckSize > 0)//check the bounds
            {
                int min = Math.Min(truckSize, boxTypes[counter][0]);//check which value is the minimum
                if (min < truckSize)//if min is less than truck size then we can safely use boxTypes[counter][0] to add to the max
                {
                    maxLoad += boxTypes[counter][0] * boxTypes[counter][1];
                    truckSize -= min;//decrement the box space we have left
                }
                else
                {
                    maxLoad += truckSize * boxTypes[counter][1];//since the min is greated than or equal to the truckSize we can just
                                                                //use the truckSize to multiply the units of the box
                    truckSize = 0;//set the size leftover to 0
                }
                counter++;
            }
            return maxLoad;//return the max load
        }
    }
}
