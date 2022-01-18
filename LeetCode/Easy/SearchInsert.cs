namespace Easy
{
    // Issue: 35
    class SearchInsertTask
    {
        public int SearchInsert(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int middle = (left + right) / 2;
                if (nums[middle] == target)
                    return middle;
                if (nums[middle] > target)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
            return left;
        }
    }
}
