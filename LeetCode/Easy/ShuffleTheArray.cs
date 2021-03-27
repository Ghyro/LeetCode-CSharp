namespace Easy
{
  class ShuffleTheArray
  {
    public int[] Shuffle(int[] nums, int n)
    {
      int[] result = new int[nums.Length];
      int index = 0;
      for (int i = 0; i < n; i++)
      {
        result[index] = nums[i];
        result[index + 1] = nums[i + n];
        index += 2;
      }
      return result;
    }
  }
}
