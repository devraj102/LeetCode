using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode1448
    {
        int count = 0;
        public int GoodNodes(TreeNode root)
        {
            BSTTraverse(root, root.val);
            return count;
        }
        private void BSTTraverse(TreeNode root, int val)
        {
            if (root == null)
            {
                return;
            }

            if (root.val >= val)
            {
                val = root.val;
                count++;
            }
            if (root.left != null)
            {
                BSTTraverse(root.left, val);
            }
            if (root.right != null)
            {
                BSTTraverse(root.right, val);
            }
        }
    }
}
