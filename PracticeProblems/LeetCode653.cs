using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode653
    {
        List<int> list;
        public bool FindTarget(TreeNode root, int k)
        {
            list = new List<int>();
            return TwoSum(root, k);
        }

        public bool TwoSum(TreeNode root, int target)
        {
            bool result = false;
            TraverseTree(root);
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (!dict.ContainsKey(list[i]))
                {
                    dict.Add(list[i], i);
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                int check = target - list[i];
                if (dict.ContainsKey(check) && dict[check] != i)
                {
                    result = true;
                }
            }
            return result;
        }

        private void TraverseTree(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            list.Add(root.val);
            TraverseTree(root.left);
            TraverseTree(root.right);
        }
    }
}
