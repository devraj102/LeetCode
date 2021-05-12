using System;

namespace LeetCode
{
    public class DiameterOfBinaryTreeProblem
    {
        int diameter = 1;
        public int DiameterOfBinaryTree(TreeNode root)
        {
            Diameter(root);
            return diameter - 1;
        }
        public int Diameter(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int lhight = Diameter(root.left);
            int rHight = Diameter(root.right);
            diameter = Math.Max(diameter, lhight + rHight + 1);
            return Math.Max(lhight, rHight) + 1;
        }
    }
}
