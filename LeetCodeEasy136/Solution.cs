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
            if(nums.Length == 1)
                return nums[0];

            Dictionary<int,int> track = new Dictionary<int,int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (track.TryGetValue(nums[i], out int value))
                    track[nums[i]] = ++value;
                else
                    track.Add(nums[i], 1);
            }

            return track.FirstOrDefault(x => x.Value == 1).Key; 
        }
    }
}
