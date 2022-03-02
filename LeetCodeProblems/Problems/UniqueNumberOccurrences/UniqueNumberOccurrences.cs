using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.UniqueNumberOccurrences
{
    public class UniqueNumberOccurrences
    {
        public bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();//createa dictionary
            for(int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))//check if the key is already in the dictionary
                    dict[arr[i]]++;//if so, increase the occurrence
                else
                    dict[arr[i]] = 1;//otherwise, add the key and set the occurrence to 1
            }

            HashSet<int> uniqueOccurrences = new HashSet<int>();//create a hashset
            foreach(KeyValuePair<int,int> pair in dict)//for each keyvaluepair in the dictionary
            {
                if (uniqueOccurrences.Contains(pair.Value))//check if the unique occurrences set contains the value of the current key, if it does then return false
                    return false;
                else
                    uniqueOccurrences.Add(pair.Value);//otherwise add the value to the set, the value of the pair is the occurrences count
            }

            return true;//if we reached this point int he code, it means we have unique occurrences

        }
    }
}
