using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode538
    {
        int sum = 0;
        public TreeNode ConvertBST(TreeNode root)
        {
            return TraverseTree(root);
        }
        private TreeNode TraverseTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            TreeNode tree = new TreeNode(0);
            tree.right = TraverseTree(root.right);
            sum += root.val;
            tree.val = sum;
            tree.left = TraverseTree(root.left);
            return tree;
        }
    }
}
