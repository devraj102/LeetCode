using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class TreeTraversal_Iterative
    {
        public void InOrderTraversal(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            var curr = root;
            while (stack.Count > 0 || curr != null)
            {
                while (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }
                curr = stack.Pop();
                Console.WriteLine(curr.val);
                curr = curr.right;
            }
        }

        /// <summary>
        /// pre order tree traversal
        /// </summary>
        /// <param name="root"></param>
        public void PreOrderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var temp = stack.Pop();
                Console.WriteLine(temp.val);
                if (temp.right != null)
                {
                    stack.Push(temp.right);
                }
                if (temp.left != null)
                {
                    stack.Push(temp.left);
                }
            }
        }

        /// <summary>
        /// post order tree traversal
        /// </summary>
        /// <param name="root"></param>
        public void PostOrderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            Stack<TreeNode> stack = new Stack<TreeNode>();
            Stack<int> result = new Stack<int>();

            stack.Push(root);
            while (stack.Count > 0)
            {
                var temp = stack.Pop();
                result.Push(temp.val);
                if (temp.left != null)
                {
                    stack.Push(temp.left);
                }

                if (temp.right != null)
                {
                    stack.Push(temp.right);                    
                }
               
            }
            while (result.Count > 0)
            {
                Console.Write(result.Pop());
            }
        }
        /// <summary>
        /// BFS
        /// </summary>
        /// <param name="root"></param>
        public void BreadthFirstSearch(TreeNode root)
        {
            Queue<TreeNode> nodes = new Queue<TreeNode>();

            nodes.Enqueue(root);
            while (nodes.Count > 0)
            {
                var temp = nodes.Dequeue();
                Console.WriteLine(temp.val);
                if (temp.left != null)
                {
                    nodes.Enqueue(temp.left);
                }
                if (temp.right != null)
                {
                    nodes.Enqueue(temp.right);
                }
            }            
        }

        /// <summary>
        /// DFS
        /// </summary>
        /// <param name="root"></param>
        public void DepthFirstSearch(TreeNode root)
        {
            Stack<TreeNode> nodes = new Stack<TreeNode>();

            nodes.Push(root);
            while (nodes.Count > 0)
            {
                var temp = nodes.Pop();
                Console.WriteLine(temp.val);
                if (temp.right != null)
                {
                    nodes.Push(temp.right);
                }
                if (temp.left != null)
                {
                    nodes.Push(temp.left);
                }
            }
        }
    }
}