namespace LeetCode
{
    public class LeetCode938
    {
        int sum = 0;
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            TraverseTree(root, low, high);
            return sum;
        }
        public void TraverseTree(TreeNode root, int low, int high)
        {
            if (root == null)
            {
                return;
            }
            if (root.val>=low && root.val<=high)
            {
                sum += root.val;
            }
            TraverseTree(root.left, low, high);
            TraverseTree(root.right, low, high);
            return;
        }
    }
}
