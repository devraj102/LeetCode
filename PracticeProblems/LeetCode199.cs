using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class LeetCode199
    {
        public IList<int> RightSideView(TreeNode root)
        {
            if (root == null)
            {
                return new List<int>();
            }
            IList<int> list = new List<int>();
            Queue<TreeNode> trees = new Queue<TreeNode>();
            trees.Enqueue(root);
            while (trees.Count > 0)
            {
                int count = trees.Count;
                while (count != 0)
                {
                    var node = trees.Dequeue();
                    if (count == 1)
                    {
                        list.Add(node.val);
                    }
                    if (node.left != null)
                    {
                        trees.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        trees.Enqueue(node.right);
                    }
                    count--;
                }
            }
            return list;
        }
    }
}
