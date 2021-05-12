namespace LeetCode.Arrays
{
    public class CyclicallyRotateAnArrayByOne
    {

        // T - O(N)
        // S - O(N)
        public void Rotate(int[] nums, int k)
        {
            int[] array = new int[nums.Length];
            int j = 0;
            k %= nums.Length;
            for (int i = nums.Length - k; i < nums.Length; i++)
            {
                array[j] = nums[i];
                j++;
            }

            for (int i = 0; i < nums.Length - k; i++)
            {
                array[j] = nums[i];
                j++;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = array[i];
            }
        }


        // slow then first method but uses constant space
        // T - (nums.Length - k)*nums.Length => m*n
        // S - O(1)
        public void Rotate2(int[] nums, int k)
        {
            k %= nums.Length;
            int count = 0;
            while(count<nums.Length -  k)
            {
                int first = nums[0];
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    nums[i] = nums[i + 1];
                }
                nums[nums.Length - 1] = first;
                count++;
            }            
        }

        // slow then first method but uses constant space
        // T - (nums.Length - k)*nums.Length => m*n
        // S - O(1)
        public void Rotate3(int[] nums, int k)
        {
            k %= nums.Length;
            int count = 0;
            while (count < k)
            {
                int last = nums[nums.Length-1];
                for (int i = 1; i < nums.Length ; i++)
                {
                    nums[i] = nums[i-1];
                }
                nums[0] = last;
                count++;
            }
        }

        // T - O(N)
        // S - O(1)
        public void Rotate4(int[] nums, int k)
        {
            if (k == 0) return;

            k %= nums.Length;

            Reverse(nums, 0, nums.Length - 1);

            Reverse(nums, 0, k - 1);
            Reverse(nums, k, nums.Length - 1);
        }

        private void Reverse(int[] nums, int left, int right)
        {
            while (left < right)
            {
                var temp = nums[left];
                nums[left] = nums[right];
                nums[right] = temp;

                left++;
                right--;
            }
        }
    }
}
