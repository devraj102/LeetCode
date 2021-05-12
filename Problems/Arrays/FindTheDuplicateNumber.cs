using System.Collections.Generic;

namespace LeetCode.Arrays
{
    public class FindTheDuplicateNumber
    {
        // T- O(N)
        // S - O(N)
        public int FindDuplicate(int[] nums)
        {
            HashSet<int> has = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if(has.Contains(nums[i]))
                {
                    return nums[i];
                }
                has.Add(nums[i]);
            }
            return 0;
        }

        // T - O(N)
        // S - O(N)
        public int FindDuplicate_FastSlowPointer(int[] nums)
        {
            int sp, fp, init;
            init = nums[0];
            //the fast pointer goes twice the speed as the slow one
            sp = nums[init];
            fp = nums[nums[init]];
            //phase 1: the fast pointer meets at node
            while (sp != fp)
            {
                sp = nums[sp];
                fp = nums[nums[fp]];
            }
            //phase 2: move sp back to the initial point and reset faster point to the same speed
            sp = init;
            while (sp != fp)
            {
                sp = nums[sp];
                fp = nums[fp];
            }
            return sp;
        }
    }
}
