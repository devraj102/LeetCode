using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class SearchMatrixProblem
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                if (BinarySearch(matrix[i], target))
                {
                    return true;
                }
            }
            return false;
        }
        public bool BinarySearch(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (target == nums[mid])
                {
                    return true;
                }
                else if (target > nums[mid])
                {
                    low = mid+1;
                }
                else
                {
                    high = mid;
                }
            }
            return false;
        }
        public bool SearchMatrix1(int[][] matrix, int target)
        {
            int low = 0;
            int high = matrix[0].Length;
            int mid = 0;
            while (low < high)
            {
                mid = low + (high - low) / 2;
                if (target <= matrix[0][mid])
                {
                    break;
                }
                else if (matrix[0][low] < target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid;
                }
            }
            Console.WriteLine(mid);
            int l = 0;
            int h = matrix.Length;
            int m = 0;
            while (l < h)
            {
                m = l + (h - l) / 2;
                if (target == matrix[m][mid])
                {
                    return true;
                }
                else if (matrix[m][mid] < target)
                {
                    h = m - 1;
                }
                else
                {
                    h = m;
                }
            }
            Console.WriteLine(m);
            low = 0;
            high = matrix[0].Length;
            mid = 0;
            while (low < high)
            {
                mid = low + (high - low) / 2;
                if (target <= matrix[mid][0])
                {
                    break;
                }
                else if (matrix[mid][0] < target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid;
                }
            }
            Console.WriteLine(mid);
            l = 0;
            h = matrix.Length; //matrix[mid];
            while (l < h)
            {
                m = l + (h - l) / 2;
                if (target == matrix[mid][m])
                {
                    return true;
                }
                else if (matrix[mid][m] < target)
                {
                    h = m - 1;
                }
                else
                {
                    l = m;
                }
            }
            Console.WriteLine(m);
            return false;
        }
    }
}
