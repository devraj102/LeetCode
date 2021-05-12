using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode48
    {
        public void Rotate(int[][] matrix)
        {
            int[][] result = new int[matrix.Length][];
            for (int i = 0; i < matrix.Length; i++)
            {
                result[i] = new int[matrix[i].Length];
            }
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    result[j][matrix[i].Length - i - 1] = matrix[i][j]; 
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {

                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = result[i][j];
                }
            }
        }
    }
}
