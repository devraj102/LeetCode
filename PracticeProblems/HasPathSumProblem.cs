using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class HasPathSumProblem
    {
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
            {
                return false;
            }
            sum = sum - root.val;
            if (root.left == null && root.right == null && sum == 0)
            {
                return true;
            }
            return HasPathSum(root.left, sum) || HasPathSum(root.right, sum);
        }

        /// <summary>
        /// DFS
        /// </summary>
        /// <param name="root"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public bool HasPathSum1(TreeNode root, int sum)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count>0)
            {
                var node  = stack.Pop();
                Console.WriteLine(node.val);
                if(node.left !=null)
                {
                    stack.Push(node.left);
                }
                if (node.left != null)
                {
                    stack.Push(node.right);
                }
            }
            return true;
        }
    }
}
