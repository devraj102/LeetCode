using System;

namespace LeetCode
{
    public class MaxDepthProblem
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            { 
                return 0;
            }
            int lhight = MaxDepth(root.left) + 1;
            int rHight =MaxDepth(root.right) + 1;
            return Math.Max(lhight, rHight);
        }
    }
}
