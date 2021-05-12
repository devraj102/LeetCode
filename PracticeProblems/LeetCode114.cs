using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode114
    {
       List<int> list;
        public void Flatten1(TreeNode root)
        {
            list = new List<int>();
            TraverseTree(root);
            root = null;
            root = new TreeNode(-1);
            var cur = root;
            var left = cur;
            foreach (var item in list)
            {
                 
                cur.right = new TreeNode(item);
                left.left = null;
                cur = cur.right;
                cur.left = left;
            }
            root = root.right;
        }
        public void TraverseTree(TreeNode root)
        {
            if(root==null)
            {
                return;
            }
            list.Add(root.val);
            TraverseTree(root.left);
            TraverseTree(root.right);
        }
    }
}
