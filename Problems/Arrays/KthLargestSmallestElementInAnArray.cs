using System;

namespace LeetCode.Arrays
{
    public class KthLargestSmallestElementInAnArray
    {
        // T-> O(NLogN)
        // S -> O(1)
        public int KthLargestElement(int[] array, int k)
        {
            Array.Sort(array);
            return array[array.Length - k];
        }

        public int KthSmallestElement(int[] array, int k)
        {
            Array.Sort(array);
            return array[k-1];
        }
    }
}
