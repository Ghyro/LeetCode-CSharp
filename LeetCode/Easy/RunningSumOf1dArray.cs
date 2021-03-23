namespace Easy
{
  public class RunningSumOf1dArray
  {
    public int[] RunningSum(int[] nums)
    {
      var result = new int[nums.Length];
      var counter = 0;
      for (var i = 0; i < nums.Length; i++)
      {
          result[i] = counter + nums[i];
          counter = result[i];
      }
      return result;
    }
  }
}
