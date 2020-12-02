using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Trees
{
    public class BasicNode
    {
        public int Key { get; private set; }
        public BasicNode Right { get; set; }
        public BasicNode Left { get; set; }


        public BasicNode(int key)
        {
            Key = key;
            Right = null;
            Left = null;
        }
    }
}
