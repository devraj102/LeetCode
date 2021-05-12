using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode144
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return new List<int>();
            }
            IList<int> list = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var temp = stack.Pop();
                list.Add(temp.val);
                if (temp.right != null)
                {
                    stack.Push(temp.right);
                }
                if (temp.left != null)
                {
                    stack.Push(temp.left);
                }
            }
            return list;
        }
    }
}
