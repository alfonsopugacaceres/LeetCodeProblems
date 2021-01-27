using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.RobotRoomCleaner
{
    public class RobotRoomCleaner
    {
        public interface Robot
        {
            // Returns true if the cell in front is open and robot moves into the cell.
            // Returns false if the cell in front is blocked and robot stays in the current cell.
            public bool Move();     
            // Robot will stay in the same cell after calling turnLeft/turnRight.
            // Each turn will be 90 degrees.
            public void TurnLeft();
            // Robot will stay in the same cell after calling turnLeft/turnRight.
            // Each turn will be 90 degrees.
            public void TurnRight();
            public void Clean();
        }

        enum Direction {
            Up = 1,
            Down = 2,
            Left = 3,
            Right = 4
        };

        public void CleanRoom(Robot robot)
        {
            IList<IList<int>> traversal = new List<IList<int>>();
            


            while (true)
            {
                while (robot.Move())
                {
                    traversal.Add(AddRow(1));
                }
                traversal.Add(AddRow(0));

            }
        }

        public IList<int> AddRow(int val)
        {
            return new List<int> { val };
        }
    }
}
