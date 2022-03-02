using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.DestinationCity
{
    /// <summary>
    /// 1436. Destination City
    /// </summary>
    public class DestinationCity
    {
        public string DestCity(IList<IList<string>> paths)
        {

            HashSet<string> tripStart = new HashSet<string>();//keep track of starts
            HashSet<string> tripEnds = new HashSet<string>();//keep track of ends
            foreach (List<string> trip in paths)//loop through all the paths
            {
                if (!tripStart.Contains(trip[0]))//if the start does not contain the current start add it
                    tripStart.Add(trip[0]);
                if (tripEnds.Contains(trip[0]))//if the ends contain the current start remove it
                    tripEnds.Remove(trip[0]);
                if (!tripStart.Contains(trip[1]) && !tripEnds.Contains(trip[1]))//if the starts do not contain the current end 
                    tripEnds.Add(trip[1]);//and the ends do not contain the current end add it to the hashset of ends
            }

            foreach (string s in tripEnds)//there is no easy way of iterating through hashsets
                return s;//return the only answer
            return string.Empty;
        }
    }
}
