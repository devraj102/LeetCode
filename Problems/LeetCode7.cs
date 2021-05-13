using System;
using System.Collections.Generic;
using System.Linq;
namespace LeetCode
{
    public class LeetCode7
    {
        public int Reverse(int x)
        {
            int result = 0;
            if (x < 0)
            {
                x = x * -1;
                while (x != 0)
                {
                    try
                    {

                        result = checked(result * 10 + x % 10);
                        x = x / 10;
                    }
                    catch (Exception ex)
                    {
                        string dd = ex.Message;
                        return 0;
                    }
                }
                result = result * -1;
            }
            else
            {
                while (x != 0)
                {
                    try
                    {
                        result = checked(result * 10 + x % 10);
                        x = x / 10;
                    }
                    catch (Exception ex)
                    {
                        string dd = ex.Message;
                        return 0;
                    }
                }
            }
            return result;
        }
    }
}