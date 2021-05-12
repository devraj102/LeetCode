using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode1038
    {
        int sum = 0;
        public TreeNode BstToGst(TreeNode root)
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
            //Console.WriteLine(sum);
            tree.left = TraverseTree(root.left);
            return tree;
        }
    }
}
