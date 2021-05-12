using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode96
    {
        List<List<int>> listofList;
        public int NumTrees(int n)
        {
            listofList = new List<List<int>>();
            int[] num = new int[3];
            for (int i = 0; i < n; i++)
            {
                num[i] = ++i;
            }
            for (int i = 0; i < num.Length; i++)
            {
                AllPermutation(num, num.Length, num.Length);
            }
            var node = BST(num, 0);
            return 5;
        }
        public void AllPermutation(int[] num, int l, int r)
        {
            if (r == 1)
            {
                List<int> list = new List<int>();
                for (int i = 0; i < num.Length; i++)
                {
                    list.Add(num[i]);

                }
                listofList.Add(list);
            }
            else
            {
                for (int i = 0; i < r; i++)
                {
                    AllPermutation(num, l, r - 1);
                    // if size is odd, swap 0th i.e (first) and
                    // (size-1)th i.e (last) element
                    if (r % 2 == 1)
                    {
                        int temp = num[0];
                        num[0] = num[r - 1];
                        num[r - 1] = temp;
                    }

                    // If size is even, swap ith and
                    // (size-1)th i.e (last) element
                    else
                    {
                        int temp = num[i];
                        num[i] = num[r - 1];
                        num[r - 1] = temp;
                    }
                }
            }
        }
        private TreeNode BST(int[] num, int i)
        {
            if(i>=num.Length)
            {
                return null;
            }
            TreeNode node = new TreeNode(num[i]);
            if (node.val < num[i])
            {
                node.left = BST(num, i + 1);
            }
            else
            {
                node.right = BST(num, i + 1);
            }
            return node;
        }
    }
}
