using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class IsHappyNumber
    {
        HashSet<int> dict = new HashSet<int>();
        public bool IsHappy(int n)
        {
            int squareSum = 0;
            if (n == 1)
            {
                return true;
            }
            while (n != 0)
            {
                int number = n % 10;
                number *= number;
                squareSum += number;
                n = n / 10;
            }
            if (dict.Contains(squareSum))
            {
                return false;
            }
            else
            {
                dict.Add(squareSum);
            }
            return IsHappy(squareSum);
        }
           
        public bool IsHappy1(int n)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int squareSum = 0;
            while (squareSum != 1)
            {
                squareSum = 0;
                while (n != 0)
                {
                    int number = n % 10;
                    number *= number;
                    squareSum += number;
                    n = n / 10;
                }
                if (dict.ContainsKey(squareSum))
                {
                    return false;
                }
                else
                {
                    dict.Add(squareSum, 1);
                }
                n = squareSum;
            }
            return true;
        }
    }
}
