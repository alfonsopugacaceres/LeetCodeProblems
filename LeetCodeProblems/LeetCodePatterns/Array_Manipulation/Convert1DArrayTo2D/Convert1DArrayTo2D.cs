using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.GoogleRecommended.GooglePatterns.Convert1DArrayTo2D
{
    class Convert1DArrayTo2D
    {

        //tags google

        //2022. Convert 1D Array Into 2D Array


        //You are given a 0-indexed 1-dimensional(1D) integer array original, and two integers, m and n.
        //You are tasked with creating a 2-dimensional(2D) array with m rows and n columns using all the elements from original.
        //The elements from indices 0 to n - 1 (inclusive) of original should form the first row of the constructed 2D array, 
        //the elements from indices n to 2 * n - 1 (inclusive) should form the second row of the constructed 2D array, and so on.
        //Return an m x n 2D array constructed according to the above procedure, or an empty 2D array if it is impossible.
        public int[][] Construct2DArray(int[] original, int m, int n)
        {
            if (original.Length != m * n)//check that the length of the original array can actually be turned into an m*n matrix
                return new int[0][];

            int[][] result = new int[m][];//create the m*n matrix

            for (int i = 0; i < result.Length; i++)//create the m*n matrix
                result[i] = new int[n];

            for (int i = 0; i < original.Length; i++)//assign all values with by calculating the indexes based on division and modulo operator
                result[i / n][i % n] = original[i];
            return result;//return the matrix
        }
    }
}
