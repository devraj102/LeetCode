namespace LeetCode.Arrays
{
    public class MinMaxElementInArray
    {
        public struct MinMax
        {
            public int Min { get; set; }
            public int Max { get; set; }
        }

        // O(n)
        public MinMax MinMaxElement(int[] array)
        {
            MinMax minMax = new MinMax();
            minMax.Min = int.MaxValue;
            minMax.Max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (minMax.Max < array[i])
                {
                    minMax.Max = array[i];
                }
                if(minMax.Min>array[i])
                {
                    minMax.Min = array[i];
                }
            }
            return minMax;
        }

        //  O(n/2)
        // divide array in 2 half and search in each array
        public MinMax MinMaxElement2(int[] array)
        {
            MinMax minMax = new MinMax();
            minMax.Min = int.MaxValue;
            minMax.Max = int.MinValue;
            int j = array.Length - 1;
            int i = 0;
            int rightMin = int.MaxValue;
            int rightMax = int.MinValue;

            while (i < j)
            {
                if (minMax.Max < array[i])
                {
                    minMax.Max = array[i];
                }
                if (minMax.Min > array[i])
                {
                    minMax.Min = array[i];
                }
                if (rightMax < array[j])
                {
                    rightMax = array[j];
                }
                if (rightMin > array[j])
                {
                    rightMin = array[j];
                }
                i++;
                j--;
            }
            if (minMax.Max < rightMax)
            {
                minMax.Max = rightMax;
            }
            if (minMax.Min > rightMin)
            {
                minMax.Min = rightMin;
            }

            return minMax;
        }
    }
}
