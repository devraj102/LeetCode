using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class FindSecondMinimumValueProblem
    {
        List<int> hash = new List<int>();
        public int FindSecondMinimumValue(TreeNode root)
        {
            Traverse(root);
            int[] result = hash.OrderBy(x => x).ToArray<int>();
            return result.Length == 1 ? -1 : result[1];
        }
        public TreeNode Traverse(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            Console.WriteLine(root.val);
            if (!hash.Contains(root.val))
            {
                hash.Add(root.val);
            }
            root.left = Traverse(root.left);
            root.right = Traverse(root.right);
            return root;
        }
    }
}
