using System.Collections.Generic;

namespace Medium
{
    // Issue: 137
    public class SingleNumberII
    {
        public int SingleNumber(int[] nums)
        {
            var dct = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dct.ContainsKey(nums[i]))
                {
                    dct[nums[i]]++;
                }
                else
                {
                    dct.Add(nums[i], 1);
                }
            }
            foreach (var item in dct)
            {
                if (item.Value == 1)
                {
                    return item.Key;
                }
            }
            return -1;
        }
    }
}
