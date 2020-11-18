using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.ShortestPathAlgorithm
{
    public class ShortestPathAlgorithm
    {

        private IList<SP_Node> _visited;

        public class SP_Node
        {
            private int _id;
            private IList<SP_Node> _neighbors;
            private Object _data;
            public SP_Node(int id, object data)
            {
                _id = id;
                _data = data;
                _neighbors = new List<SP_Node>();
            }

            public IList<SP_Node> Neighbors { get; }

        }


        public ShortestPathAlgorithm()
        {
            _visited = new List<SP_Node>();
        }


        public void FindShortestDistance(SP_Node start)
        {

            foreach(SP_Node neighbor in start.Neighbors)
            {

            }

        }

    }
}
