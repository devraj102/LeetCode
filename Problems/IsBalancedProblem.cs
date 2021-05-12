using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class IsBalancedProblem
    {
        int difference = 0;
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            return Math.Abs(Depth(root.left) - Depth(root.right)) > 1 ? false : true;
        }
        public int Depth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int lHight = Depth(root.left) + 1;
            int rHight = Depth(root.right) + 1;
            difference = Math.Abs(lHight - rHight);
            return Math.Max(lHight, rHight);
        }
    }
}
