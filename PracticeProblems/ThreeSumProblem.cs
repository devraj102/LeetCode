using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class ThreeSumProblem
    {
        public List<List<int>> ThreeSum(int[] nums)
        {
            List<List<int>> list = new List<List<int>>();
            for (int i = 0; i < nums.Length-2; i++)
            {
                List<int> array = new List<int>();
                for (int j = i+1; j < nums.Length; j++)
                {
                    for (int k = j+1; k < nums.Length; k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            list.Add(new List<int>() { nums[i], nums[j], nums[k] });
                        }
                    }
                    
                }
            }
            return list;
        }
    }
}
