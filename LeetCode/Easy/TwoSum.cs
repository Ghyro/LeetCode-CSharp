using System.Collections.Generic;

namespace Easy
{
    // Issue: 1

    //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    //You may assume that each input would have exactly one solution, and you may not use the same element twice.
    //You can return the answer in any order.

    class TwoSum
    {
        public int[] TwoSumAlg(int[] nums, int target)
        {
            var hash = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var vl = target - nums[i];
                if (hash.ContainsKey(vl))
                    return new[] { hash[vl], i };

                if (!hash.ContainsKey(nums[i]))
                    hash.Add(nums[i], i);
            }
            return null;
        }
    }
}
