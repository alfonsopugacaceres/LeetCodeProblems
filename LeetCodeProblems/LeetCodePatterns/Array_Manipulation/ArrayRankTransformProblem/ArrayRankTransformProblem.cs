using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.XPath;

namespace LeetCodeProblems.LeetCodePatterns.Array_Manipulation.AmazonProblems
{
    public class ArrayRankTransformProblem
    {
        //1331. Rank Transform of an Array

//        Given an array of integers arr, replace each element with its rank.

//The rank represents how large the element is. The rank has the following rules:

//Rank is an integer starting from 1.
//The larger the element, the larger the rank.If two elements are equal, their rank must be the same.
//Rank should be as small as possible.
        public int[] ArrayRankTransform(int[] arr)
        {
            if(arr.Length < 0 || arr.Length > 100000)//edge cases
            {
                return null;
            }
            else
            {
                int rank = 1;//start ranks at 1
                int[] sortedArray = new int[arr.Length];//create a new array, same length
                int[] rankArr = new int[arr.Length];//create a rank array
                Array.Copy(arr, sortedArray, arr.Length);//copy the values over so we can sort
                Array.Sort(sortedArray);//sort the array
                IDictionary<int, int> dict = new Dictionary<int, int>();//create a dictionary

                for(int i = 0; i < sortedArray.Length; i++)//loop through the sorted array
                {
                    //if the dictionary does not contain 
                    //the given key, add the current rank
                    //to the dictionary and increment rank
                    if (!dict.ContainsKey(sortedArray[i]))
                    {
                        dict.Add(sortedArray[i], rank);
                        rank++;
                    }
                }

                //loop through the array and add the rank number to the rank array
                for(int i = 0; i < arr.Length; i++)
                {
                    rankArr[i] = dict[arr[i]];
                }

                //return the rank array
                return rankArr;
            }
        }
    }
}
