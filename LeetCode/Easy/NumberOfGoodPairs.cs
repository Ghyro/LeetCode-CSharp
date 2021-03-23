namespace Easy
{
  class NumberOfGoodPairs
  {
    public int NumIdenticalPairs(int[] nums)
    {
      var pairs = 0;
      for (var i = 0; i < nums.Length; i++)
      {
        for (var j = i + 1; j < nums.Length; j++)
        {
          if (nums[i] == nums[j] && i < j)
              pairs++;
        }
      }
      return pairs;
    }
  }
}
