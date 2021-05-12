namespace LeetCode
{
    public class LeetCode923
    {
        public int ThreeSumMulti(int[] arr, int target)
        {
            if (arr.Length < 3)
            {
                return 0;
            }
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int j = i + 1;
                int k = arr.Length - 1;

                while (j < k)
                {
                    int sum = arr[i] + arr[j] + arr[k];
                    if (sum == target)
                    {
                        count++;
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
            return count;
        }
    }
}
