using System.Collections.Generic;
using System.Linq;
namespace LeetCode
{
    public class WidthOfBinaryTreeProblem
    {
        public int WidthOfBinaryTree(TreeNode root)
        {
            
            if (root == null)
            {
                return 0;
            }
            Queue<TreeTree> que = new Queue<TreeTree>();
            que.Enqueue(new TreeTree { Tree = root, Width = 0 });
            while (que.Count>0)
            {
                var node = que.Dequeue();
                if(node.Tree.left !=null)
                {
                   
                }
            }
            return 0;
        }
    }
    public class TreeTree
    {
        public TreeNode Tree { get; set; }
        public int Width { get; set; }
    }
}
