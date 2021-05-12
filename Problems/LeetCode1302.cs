using System.Collections.Generic;

namespace LeetCode
{
    public class LeetCode1302
    {
        public int DeepestLeavesSum(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int sum = 0;
            while (queue.Count > 0)
            {
                sum = 0;
                int count = queue.Count;
                while (count != 0)
                {
                    var node = queue.Dequeue();
                    sum += node.val;
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                    count--;
                }
            }
            return sum;
        }
    }
}