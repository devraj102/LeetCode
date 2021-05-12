using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class IsSymmetricProblem
    {
        public TreeNode InvertTree(TreeNode root)
        {


            if (root == null)
            {
                return null;
            }
            TreeNode tree = new TreeNode(root.val);
            if (root.right == null)
            {
                tree.left = null;
            }
            else
            {
                tree.left = InvertTree(root.right);
            }
            if (root.left == null)
            {
                tree.left = null;
            }
            else
            {
                tree.right = InvertTree(root.left);
            }

            return tree;
        }
    }
}
