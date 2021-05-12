using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode.Arrays
{
    /// <summary>
    /// for loop with extra memory- not good approach T - O(n), S- O(n)
    /// </summary>
    public class ReverseArrayProblems
    {
        public int[] ReverseArray(int[] array)
        {
            int[] result = new int[array.Length];
            int j = 0;
            for (int i = array.Length-1; i >=0; i--)
            {
                result[j] = array[i];
                j++;
            }
            return result;
        }


        // good approach with O(n/2) => O(n) Space O(1)
        public int[] ReverseArray2(int[] array)
        {
            int i = 0, j = array.Length-1;
            while (i<j)
            {
                int temp = array[j];
                array[j] = array[i];
                array[i] = temp;
                i++;
                j--;
            }
            return array;
        }

        public int[] ReverseArray3(int[] array)
        {

            return array.Reverse().ToArray<int>();
        }
    }
}
