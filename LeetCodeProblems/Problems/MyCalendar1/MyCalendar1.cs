using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.MyCalendar
{
    public class MyCalendar1
    {
        IList<int[]> calendar = null;
        public MyCalendar1()
        {
            calendar = new List<int[]>();
        }

        public bool Book(int start, int end)
        {
            int[] calendarEntry = new int[2];
            bool valid = true;

            foreach (var entry in calendar)
            {
                int entryStart = entry[0];
                int entryEnd = entry[1];



            }

            if (valid)
            {
                int[] newEntry = new int[2];
                newEntry[0] = start;
                newEntry[1] = end;
                calendar.Add(newEntry);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
