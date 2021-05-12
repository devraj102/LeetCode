using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LeetCode539
    {
        public int FindMinDifference(IList<string> timePoints)
        {
            int minValue = int.MaxValue;
            List<int> list = new List<int>();
            for (int i = 0; i < timePoints.Count; i++)
            {
                var timep = timePoints[i].Split(':');
                int hour = int.Parse(timep[0] == "00" ? "24" : timep[0]);
                int min = int.Parse(timep[1]);
                list.Add(hour * 60 + min);
                Console.WriteLine(hour * 60 + min);
            }
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (i != j)
                    {
                        minValue = Math.Min(Math.Abs(list[i] - list[j]), minValue);
                    }
                }
            }
            return minValue;
        }
    }
}
