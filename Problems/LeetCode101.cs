using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode101
    {
        public bool result = true;
        public bool IsSymmetric(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count>0)
            {
                var node = queue.Dequeue();

            }
            return false;
        }

        public void TraverseTree(TreeNode left, TreeNode right)
        {
            if ((left == null && right == null) || (left.val == right.val))
            {
                return;
            }
            else
            {
                result = false;
            }
            TraverseTree(left.left, right.right);
            TraverseTree(left.right, right.left);
        }
    }
}
