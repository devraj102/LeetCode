using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class LeetCode1457
    {
        int count = 0;
        public int PseudoPalindromicPaths(TreeNode root)
        {
            TreeTraverse(root, new int[10]);
            return count;
        }

        private void TreeTraverse(TreeNode root, int[] freq)
        {
            if (root == null)
            {
                return;
            }
            freq[root.val]++;
            if (root.left == null && root.right == null)
            {
                int odd = 0;
                for (int i = 0; i < freq.Length; i++)
                {
                    odd += freq[i] % 2 == 1 ? 1 : 0;
                }
                count += odd <= 1 ? 1 : 0;
            }
            TreeTraverse(root.left, freq);
            TreeTraverse(root.right, freq);
            freq[root.val]--;
        }

        public int GetAllPathOfBST(TreeNode root)
        {
            BSTTraverse(root, new List<int>());
            return 1;
        }

        private void BSTTraverse(TreeNode root, List<int> list)
        {
            if (root == null)
            {
                return;
            }
            list.Add(root.val);
            if (root.left == null && root.right == null)
            {
                foreach (var val in list)
                {
                    Console.Write(val);
                }
                Console.WriteLine("--------------");
            }
            BSTTraverse(root.left, list);
            BSTTraverse(root.right, list);
            list.Remove(root.val);
        }
    }
}
