using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.MeetingRooms
{
    public class MeetingRooms
    {
        //252. Meeting Rooms
        public bool CanAttendMeetings(int[][] intervals)
        {
            int[] meetBegin = new int[intervals.Length];//separate start times
            int[] meetEnd = new int[intervals.Length];//separate end times
            for (int i = 0; i < intervals.Length; i++)
            {
                meetBegin[i] = intervals[i][0];
                meetEnd[i] = intervals[i][1];
            }

            Array.Sort(meetBegin);//sort start times
            Array.Sort(meetEnd);//sort end times


            //loop through the intervals, check if the beginning is less than the end of the previous. 
            //this will simulate having overlap. If one start and one end overlap, the person cannot go to all meetings
            for (int i = 1; i < intervals.Length; i++)  
            {
                if (meetBegin[i] < meetEnd[i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
