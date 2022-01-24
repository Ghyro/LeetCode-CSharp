namespace Easy
{
    // Issue: 905

    // Given an integer array nums, move all the even integers at the beginning of the array followed by all the odd integers.
    // Return any array that satisfies this condition.
    // The solution must be done using in-place approach.

    class SortArrayByParityInPlace
    {
        public int[] SortArrayByParity(int[] nums)
        {
            var length = nums.Length;
            var i = 0;
            var j = length - 1;
            while (i < j)
            {
                if (nums[i] % 2 > nums[j] % 2)
                {
                    var temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
                if (nums[i] % 2 == 0) i++;
                if (nums[j] % 2 != 0) j--;
            }
            return nums;
        }
    }
}
