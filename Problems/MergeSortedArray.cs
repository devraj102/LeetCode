using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = 0;
            for (; i < nums1.Length; i++)
            {
                if (i == m)
                {
                    break;
                }
                for (int k = nums2.Length - 1; k >= 0; k--)
                {
                    if (nums1[i] > nums2[k])
                    {
                        int temp = nums1[i];
                        nums1[i] = nums2[k];
                        nums2[k] = temp;
                    }
                }
            }
            for (int k = 0; k < nums2.Length; k++)
            {
                nums1[i] = nums2[k];
                i++;
            }
        }
        public void Merge1(int[] nums1, int m, int[] nums2, int n)
        {
            int j = m;
            for (int i = 0; i < nums2.Length; i++)
            {
                nums1[j] = nums2[i];
                j++;
            }
            Array.Sort(nums1);
        }

    }
}
