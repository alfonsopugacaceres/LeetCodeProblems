using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.RingsAndRods
{
    public class RingsAndRods
    {
        //2103. Rings and Rod

        //There are n rings and each ring is either red, green, or blue.
        //The rings are distributed across ten rods labeled from 0 to 9.
        //You are given a string rings of length 2n that describes the n rings 
        //that are placed onto the rods.Every two characters in rings forms a 
        //color-position pair that is used to describe each ring where:
        //The first character of the ith pair denotes the ith ring's color ('R', 'G', 'B').
        //The second character of the ith pair denotes the rod that the ith ring is placed on ('0' to '9').
        //For example, "R3G2B1" describes n == 3 rings: a red ring placed onto the rod labeled 3, a 
        //green ring placed onto the rod labeled 2, and a blue ring placed onto the rod labeled 1.
        //Return the number of rods that have all three colors of rings on them.

        public int CountPoints(string rings)
        {
            int result = 0;//result variable
            if (rings == null || rings.Length % 2 != 0)//edge cases
                return -1;
            else
            {
                HashSet<char>[] rods = new HashSet<char>[10];//create an array of hashsets to keep track of the colors in each rod

                //loop through the array 2 at a time since we have a two character string denoting which rod and which color
                for (int i = 0; i < rings.Length; i += 2)
                {
                    string currentPair = rings.Substring(i, 2);//get a substring of the character pair
                    int index = (int)Char.GetNumericValue(currentPair[1]);//get the integer value denoting the index
                    if (rods[index] == null)//check if the rod hashset was instantiated
                        rods[index] = new HashSet<char>();//if not instantiated, create the hashset for the rod

                    if (rods[index].Count == 3)//check if it already has the 3 colors, if it does skip it
                        continue;
                    else if (!rods[index].Contains(currentPair[0]))//if the rod does not contain the current color we are trying to add
                    {
                        rods[index].Add(currentPair[0]);//add the color
                        result += (rods[index].Count == 3) ? 1 : 0;//check if with the color added we finally got the three colors in, 
                                                                   //if we did, add to the result
                    }
                }
                return result;//return the result
            }
        }

    }
}
