namespace LeetCode
{
    public class LeetCode167
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int[] result = new int[2];
            int i = 0;
            int j = numbers.Length - 1;

            while (i < j)
            {
                int sum = numbers[i] + numbers[j];
                if (sum == target)
                {
                    result[0] = i + 1;
                    result[1] = j + 1;
                    return result;
                }
                else if (sum > target)
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }
            return result;
        }
    }
}
