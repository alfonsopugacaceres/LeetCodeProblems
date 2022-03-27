using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.LeetCodePatterns.Array_Manipulation.RobotBoundedInBox
{
    class RobotBoundedInCircle
    {
        //1041. Robot Bounded In Circle
        //On an infinite plane, a robot initially stands at(0, 0) and faces north.Note that:
        //The north direction is the positive direction of the y-axis.
        //The south direction is the negative direction of the y-axis.
        //The east direction is the positive direction of the x-axis.
        //The west direction is the negative direction of the x-axis.
        //The robot can receive one of three instructions:
        //"G": go straight 1 unit.
        //"L": turn 90 degrees to the left(i.e., anti-clockwise direction).
        //"R": turn 90 degrees to the right(i.e., clockwise direction).
        //The robot performs the instructions given in order, and repeats them forever.
        //Return true if and only if there exists a circle in the plane such that the robot never leaves the circle.

        /// <summary>
        /// This problem is super tricky. To figure out if we are going stuck in a loop
        /// we have to find a cycle. A cycle represents returning to the origin where we
        /// started. However its not good enough to just end up at the origin, if we change
        /// directions from facing forward and we cycle through the instructions, we are going to 
        /// eventually be bound by a circle, we just need to change directions from facing
        /// up. With those two condition in mind and a clever way to keep track of directions
        /// we can solve this problem
        /// </summary>
        /// <param name="instructions"></param>
        /// <returns></returns>
        public bool IsRobotBounded(string instructions)
        {
            int[] direction = new int[2];//array with the direction we are facing
            direction[0] = 0;//set it to facing north
            direction[1] = 1;//set it to facing north
            int x = 0;//origin
            int y = 0;//origin

            foreach(char instruction in instructions)//for each instruction in the string
            {
                if(instruction == 'G')//if go, increment the origin with the directions respectively
                {
                    x += direction[0];
                    y += direction[1];
                }
                else if(instruction == 'L')//if we turn left
                {
                    int temp = direction[0];//we can swap the current directions of x and y, flip y -1
                    direction[0] = direction[1] * -1;
                    direction[1] = temp;
                }
                else
                {
                    int temp = direction[0];//we can swap the current directions x and y, flip x -1
                    direction[0] = direction[1];
                    direction[1] = temp * -1;
                }
            }

            if (x == 0 && y == 0)//this means we have a cycle because we returned to the origin
                return true;
            if (direction[0] != 0 || direction[1] != 1)//if we even changed any direction we are in a cycle
                return true;

            return false;//otherwise we do not have a cycle, so we cannot be bounded by a circle
        }
    }
}
