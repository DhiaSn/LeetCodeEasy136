using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeEasy136
{
    public static class Solution
    {
        public static int SingleNumber(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];

            int result = nums[0];

            for (int i = 1; i < nums.Length; i++)
                result ^= nums[i];

            return result;
        }
    }
}
