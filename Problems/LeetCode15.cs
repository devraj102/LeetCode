using System;
using System.Collections.Generic;
using System.Linq;
namespace LeetCode
{
    public class LeetCode15
    {
        
        // My solution passed all test cases but Time Limit Exceed.
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            List<List<int>> list = new List<List<int>>();
            if (nums.Length < 3)
            {
                return list.Cast<IList<int>>().ToList();
            }
            Array.Sort(nums);
            HashSet<string> hash = new HashSet<string>();

            for (int i = 0; i + 2 < nums.Length; i++)
            {
                int j = i + 1;
                int k = nums.Length - 1;

                while (j < k)
                {
                    List<int> current = new List<int>();
                    int sum = nums[i] + nums[j] + nums[k];
                    if (sum == 0)
                    {
                        var num = $"{nums[i]}{nums[j]}{nums[k]}";
                        if (!hash.Contains(num))
                        {
                            current.Add(nums[i]);
                            current.Add(nums[j]);
                            current.Add(nums[k]);
                            if (!list.Any(x => x == current))
                            {
                                list.Add(current);
                            }
                            hash.Add(num);
                        }
                        j++;
                        k--;

                    }
                    else if (sum < 0)
                    {
                        j++;
                    }
                    else
                    {
                        k--;
                    }
                }
            }
            return list.Cast<IList<int>>().ToList();
        }
    }
}