using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode94
    {
        /// <summary>
        /// iterative approach for in order Traversal
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> list = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();

            var curr = root;
            while (stack.Count > 0 || curr != null)
            {
                while (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }
                curr = stack.Pop();
                list.Add(curr.val);
                curr = curr.right;
            }
            return list;
        }
    }
}
