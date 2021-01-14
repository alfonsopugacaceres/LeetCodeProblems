using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.SortingAlgorithms
{
    public class SortingAlgorithms
    {

        public void MergeSort(int[] array, int left, int m, int right)
        {
            int length = array.Length;

            if(length < 2)
            {
                return;
            }
            else
            {
                double middle = Math.Floor(length * 0.5);

            }
        }

        private int[] MergeSortMerge(int[] a, int[] b)
        {
            int[] merged = new int[a.Length + b.Length];
            int aCounter = 0;
            int bcounter = 0;
            int mergedCounter = 0;


            while(aCounter < a.Length && bcounter < b.Length)
            {
                if(a[aCounter] <= b[bcounter])
                {
                    merged[mergedCounter] = a[aCounter];
                    aCounter++;
                    mergedCounter++;
                }
                else
                {
                    merged[mergedCounter] = b[bcounter];
                    bcounter++;
                    mergedCounter++;
                }
            }

            while(aCounter < a.Length)
            {
                merged[mergedCounter] = a[aCounter];
                aCounter++;
                mergedCounter++;
            }
            while (bcounter < b.Length)
            {
                merged[mergedCounter] = b[bcounter];
                bcounter++;
                mergedCounter++;
            }

            return merged;
        }

    }
}
