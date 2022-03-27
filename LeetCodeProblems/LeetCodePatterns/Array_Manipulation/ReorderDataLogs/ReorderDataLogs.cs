using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Array_Manipulation.ReorderDataLogs
{
    class ReorderDataLogs
    {

        //937. Reorder Data in Log Files

        //You are given an array of logs.Each log is a space-delimited string of words, where the first word is the identifier.
        //There are two types of logs:
        //Letter-logs: All words (except the identifier) consist of lowercase English letters.
        //Digit-logs: All words(except the identifier) consist of digits.
        //Reorder these logs so that:
        //The letter-logs come before all digit-logs.
        //The letter-logs are sorted lexicographically by their contents.If their contents are the same, then sort them lexicographically by their identifiers.
        //The digit-logs maintain their relative ordering.
        //Return the final order of the logs.

        /// <summary>
        /// This question can only be answered by leveraging functionality from whatever programming language you are using. 
        /// in the case of c#, we have to use linq
        /// </summary>
        /// <param name="logs"></param>
        /// <returns></returns>
        public string[] ReorderLogFiles(string[] logs)
        {
            List<string> DigitLogs = new List<string>();//list for digit logs
            List<string> TextLogs = new List<string>();//list for text logs


            foreach (string log in logs)//foreach log in logs
            {
                string[] currentLogStructure = log.Split(" ");//split the string to get the structure
                if (char.IsDigit(currentLogStructure[1][0]))//check if its a digit log
                    DigitLogs.Add(log);//add it to the digit log list
                else
                    TextLogs.Add(log);//otherwise add this set of logs to the text logs
            }

            TextLogs = TextLogs
                .OrderBy(f => f.Split(" ", 2)[1])//use the linq order by, then select element f (the string) 
                                                 //split on the space character, select the second slot on the 
                                                 //array, by default it runs the comparator on the strings properly
                .ThenBy(f => f.Split(" ", 2)[0])//do the same thing, except this time weare looking at the identifier
                .ToList();//turn it to a list instead of an icollection
            TextLogs.AddRange(DigitLogs);//add the digit logs at the end
            return TextLogs.ToArray();//return the array of strings
        }
    }
}
