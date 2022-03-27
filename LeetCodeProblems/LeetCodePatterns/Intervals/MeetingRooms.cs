using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Intervals
{
    class MeetingRooms
    {
        //252. Meeting Rooms
        //Given an array of meeting time intervals where intervals[i] = [starti, endi], determine if a person could attend all meetings.
        public bool CanAttendMeetings(int[][] intervals)
        {

            if (intervals == null || intervals.Length == 0)
                return true;

            intervals = intervals.OrderBy(x => x[0]).ToArray();

            for (int i = 0; i < intervals.Length - 1; i++)
                if (intervals[i][1] > intervals[i + 1][0])
                    return false;

            return true;

        }
    }
}
