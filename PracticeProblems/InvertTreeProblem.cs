namespace LeetCode
{
    public class InvertTreeProblem
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            TreeNode tree = new TreeNode(root.val);
            if (root.right != null)
            {
                tree.left = InvertTree(root.right);
            }

            if (root.left != null)
            {
                tree.right = InvertTree(root.left);
            }

            return tree;
        }
    }
}
