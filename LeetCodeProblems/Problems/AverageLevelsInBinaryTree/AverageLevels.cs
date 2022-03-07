using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.AverageLevelsInBinaryTree
{
    public class AverageLevels
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        public IList<double> AverageOfLevels(TreeNode root)
        {
            IDictionary<int, double[]> childrenByLevel = new Dictionary<int, double[]>();//create a dictionary to keep track of the children by level
                                                                                         //the array keeps track of the sum and occurrence
            Helper(root, childrenByLevel, 1);//do the recursive call                                              
            IList<double> ret = new List<double>();//create the result list
            foreach(KeyValuePair<int, double[]> pair in childrenByLevel)//loop trough the dictionary by level
                ret.Add(pair.Value[1] /pair.Value[0]);//get the average
            return ret;//return the answer
        }

        public void Helper(TreeNode root, IDictionary<int, double[]> childrenByLevel, int currentLevel)
        {
            if (root == null)//if root is null, return
                return;
            else
            {
                if (childrenByLevel.ContainsKey(currentLevel))//check if there is already an entry for the current level
                {
                    childrenByLevel[currentLevel][0]++;//increase counter of numbers added
                    childrenByLevel[currentLevel][1] += root.val;//increment sum by the current node val
                }
                else
                {
                    childrenByLevel[currentLevel] = new double[2];//create a new array
                    childrenByLevel[currentLevel][0] = 1;//set the initial counter to one
                    childrenByLevel[currentLevel][1] = root.val;//set the initial value
                }
                if (root.left != null)//check if there is a left, if so, do a recursive call
                    Helper(root.left, childrenByLevel, currentLevel + 1);
                if (root.right != null)//check if there is a right, if so, do a recursive call
                    Helper(root.right, childrenByLevel, currentLevel + 1);
            }
        }
    }
}
