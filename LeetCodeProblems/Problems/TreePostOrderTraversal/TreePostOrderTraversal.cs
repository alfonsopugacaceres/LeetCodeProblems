using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Problems.TreePostOrderTraversal
{
    public class TreePostOrderTraversal
    {
        public class Node
        {
            public int val;
            public IList<Node> children;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, IList<Node> _children)
            {
                val = _val;
                children = _children;
            }
            public IList<int> Postorder(Node root)
            {

                IList<int> res = new List<int>();
                Helper(root, res);
                return res;
            }
            public void Helper(Node root, IList<int> res)
            {
                if (root == null)//if the root is null return
                    return;
                if (root.children == null)//if the root has no children add the root value to the list
                    res.Add(root.val);
                else
                {
                    foreach (Node child in root.children)
                    {
                        if (child.children == null)//if the current child has no children, continue going down the chain
                            continue;
                        else
                            Helper(child, res);//recursive call on child
                    }
                    res.Add(root.val);//finally add the current root value after all the children nodes have been added
                }

            }
        }
    }
}