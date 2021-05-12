using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode145
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return new List<int>();
            }
            Stack<TreeNode> stack = new Stack<TreeNode>();
            Stack<int> result = new Stack<int>();
            IList<int> list = new List<int>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var temp = stack.Pop();
                result.Push(temp.val);

                if (temp.left != null)
                {
                    stack.Push(temp.left);
                }
                if (temp.right != null)
                {
                    stack.Push(temp.right);
                }
            }
            while (result.Count > 0)
            {
                list.Add(result.Pop());
            }
            return list;
        }
    }
}
