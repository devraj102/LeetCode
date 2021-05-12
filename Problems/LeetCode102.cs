using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class LeetCode102
    {
        IList<List<int>> listOfList;
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            listOfList = new List<List<int>>();
            if (root == null)
            {
                return listOfList.Cast<IList<int>>().ToList();
            }
            Queue<TreeNode> nodes = new Queue<TreeNode>();

            nodes.Enqueue(root);
            while (1 == 1)
            {
                int nodeCount = nodes.Count;
                if (nodeCount == 0)
                {
                    return listOfList.Cast<IList<int>>().ToList();
                }
                List<int> list = new List<int>();
                while (nodeCount > 0)
                {
                    var temp = nodes.Dequeue();
                    list.Add(temp.val);
                    if (temp.left != null)
                    {
                        nodes.Enqueue(temp.left);
                    }
                    if (temp.right != null)
                    {
                        nodes.Enqueue(temp.right);
                    }
                    nodeCount--;
                }
                listOfList.Add(list);
            }
        }
    }
}
