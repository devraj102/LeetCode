using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class LeetCode230
    {
        int count = 0;
        int result = 0;
        public int KthSmallest(TreeNode root, int k)
        {
            TraverseTree(root, k);
            return result;
        }

        public void TraverseTree(TreeNode root, int k)
        {
            if (root == null)
            {
                return;
            }
            TraverseTree(root.left, k);
            count++;
            if (count == k)
            {
                result = root.val;
                return;
            }
            TraverseTree(root.right, k);
        }
        List<int> list;
        public int KthSmallest1(TreeNode root, int k)
        {
            list = new List<int>();

            TraverseTree1(root);           
            return list.OrderBy(x=>x).Skip(k - 1).FirstOrDefault();
        }

        public void TraverseTree1(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            list.Add(root.val);
            TraverseTree1(root.left);
            TraverseTree1(root.right);
        }
    }
}
