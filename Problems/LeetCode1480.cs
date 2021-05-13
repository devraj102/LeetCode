namespace Problems
{
    public class LeetCode1480
    {
        public int[] RunningSum(int[] nums)
        {
            if (nums.Length < 2)
            {
                return nums;
            }
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] = nums[i] + nums[i - 1];
            }
            return nums;
        }
        public int[] RunningSumLess(int[] nums)
        {
            int[] result = new int[nums.Length];
            if (nums.Length < 2)
            {
                return nums;
            }
            result[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                result[i] = nums[i] + result[i - 1];
            }
            return result;
        }

    }
}