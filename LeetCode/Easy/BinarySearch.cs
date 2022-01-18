namespace Easy
{
    // Issue: 704
    public class BinarySearch
    {
        public int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int middle = (left + right) / 2;
                if (target == nums[middle])
                {
                    return middle++;
                }
                if (target < nums[middle])
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
            return -1;
        }
    }
}
