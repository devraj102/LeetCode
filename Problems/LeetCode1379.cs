using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode1379
    {
        TreeNode _target, ans;
        public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            _target = target;
            TreeTraverse(original,cloned);
            return ans;
        }

        private void TreeTraverse(TreeNode original, TreeNode cloned)
        {
            if (original == null || cloned == null)
            {
                return;
            }
            TreeTraverse(original.left, cloned.left);
            if (_target == cloned)
            {
                ans = cloned;
            }
            TreeTraverse(original.right, cloned.right);
        }
    }
}
