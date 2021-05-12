using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode897
    {
        List<int> list;
        public TreeNode IncreasingBST(TreeNode root)
        {
            list = new List<int>();
            TraverseTree(root);
            var result = new TreeNode(0);
            var cur = result;
            foreach (var item in list)
            {
                cur.right = new TreeNode(item);
                cur = cur.right;
            }
            return result.right;
        }
        public void TraverseTree(TreeNode root)
        {
            if (root == null)
            {
                return ;
            }

            TraverseTree(root.left);
            list.Add(root.val);
            TraverseTree(root.right);
        }
    }
}
