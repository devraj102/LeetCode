using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class MoveNegativeNumbersBeginning
    {
        /*
         Input:  -12, 11, -13, -5, 6, -7, 5, -3, -6
         Output: -12, -13, -5, -7, -3, -6, 11, 6, 5
         */
        public void rearrange(int[] arr, int n)
        {
            for (int i = 0; i < arr.Length -1; i++)
            {
                if(arr[i]>0)
                {
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                    i--;
                }
            }

        }
    }
}
