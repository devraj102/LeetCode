namespace LeetCode
{
    public class MergeTreesProblem
    {
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null)
            {
                return t2;
            }
            else if (t2 == null)
            {
                return t1;
            }

            TreeNode node = new TreeNode(t1.val + t2.val);
            node.left = MergeTrees(t1.left, t2.left);
            node.right = MergeTrees(t1.right, t2.right);
            return node;
        }
    }
}
