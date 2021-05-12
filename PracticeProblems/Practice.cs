using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Practice
    {
        int count = 0;
        public void PowerSetOfString(string input, int i, string set)
        {
            Console.WriteLine(++count);
            if(i==input.Length)
            {
                foreach (var item in set)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("-----------");
                return;
            }
            PowerSetOfString(input, i + 1, set + input[i]);
            PowerSetOfString(input, i + 1, set);
        }
        public void PermutationString(string nums, int l, int r)
        {
            if (l == r)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write(nums[i]);
                }
                Console.WriteLine("------------");
            }
            else
            {
                for (int i = l; i <= r; i++)
                {
                    swap(nums, l, r);
                    PermutationString(nums, l + 1, r);
                    swap(nums, l, r);
                }
            }
        }
        private void swap(string nums, int l, int r)
        {
            char temp = nums[l];
            //nums[l] = nums[r];
            //nums[r] = temp;
        }
        public void Permutation(int[] nums, int l, int r)
        {
            if (l == r)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write(nums[i]);
                }
                Console.WriteLine("------------");
            }
            else
            {
                for (int i = l; i <= r; i++)
                {
                    swap(nums, l, i);
                    Permutation(nums, l + 1, r);
                    swap(nums, l, i);
                }
            }
        }
        private void swap(int[] nums, int l, int r)
        {
            int temp = nums[l];
            nums[l] = nums[r];
            nums[r] = temp;
        }
    }
}
