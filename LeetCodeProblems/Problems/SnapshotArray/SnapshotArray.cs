using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.SnapshotArray
{
    public class SnapshotArray
    {
        int snapCount;//count of snaps
        IDictionary<int, IDictionary<int, int>> SnapshotToArrayValues;//dictionary with snapshots and index/values


        public SnapshotArray(int length)
        {
            snapCount = 0;//initialize snap = 0
            SnapshotToArrayValues = new Dictionary<int, IDictionary<int, int>>();//initialize the dictionary
            SnapshotToArrayValues[snapCount] = new Dictionary<int, int>();//initialize the first instance of the dictionary
        }


        public void Set(int index, int val)
        {

            if (SnapshotToArrayValues[snapCount].ContainsKey(index))//if the dictionary at the snap has the index
                SnapshotToArrayValues[snapCount][index] = val;//just set and replace the value
            else
                SnapshotToArrayValues[snapCount].Add(index, val);//otherwise add the value to the dictionary
        }

        public int Snap()
        {
            int snap = snapCount;//keep the previous snapcount
            snapCount++;//increment the snapcount

            SnapshotToArrayValues[snapCount] = new Dictionary<int, int>();//instantiate the dictionary at the new dictionary
            if (SnapshotToArrayValues[snapCount - 1].Count > 0)//check if the previous dictionary has keys
                foreach (KeyValuePair<int, int> pair in SnapshotToArrayValues[snapCount - 1])//if it does, copy the previous keys and values into the new dictionary
                    SnapshotToArrayValues[snapCount].Add(pair.Key, pair.Value);

            return snap;
        }

        public int Get(int index, int snap_id)
        {
            if (SnapshotToArrayValues.ContainsKey(snap_id))//check for the snap id having already happened
            {
                if (SnapshotToArrayValues[snap_id].ContainsKey(index))//check if the index is there
                    return SnapshotToArrayValues[snap_id][index];//return the value if its there
                else
                    return 0;//otherwise we return 0
            }
            else
                return 0;
        }
    }
}
