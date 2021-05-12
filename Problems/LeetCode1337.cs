using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class LeetCode1337
    {
        public int[] KWeakestRows(int[][] mat, int k)
        {

            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < mat.Length; i++)
            {
                int soldierCount = 0;
                for (int j = 0; j < mat[i].Length; j++)
                {
                    if (mat[i][j] == 1)
                    {
                        soldierCount++;
                    }
                }
                dict.Add(i, soldierCount);
            }
            return dict.OrderBy(x => x.Value).ThenBy(x => x.Key).Take(k).Select(x => x.Key).ToArray<int>();
        }
    }
}
