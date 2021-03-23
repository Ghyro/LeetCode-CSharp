using System;
using System.Collections.Generic;
using System.Text;

namespace Easy
{
  class HowManyNumbersAreSmallerThanTheCurrentNumber
  {
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
      var result = new int[nums.Length];
      for (int i = 0; i < nums.Length; i++)
      {
        var counter = 0;
        var index = nums[i];
        foreach (var t in nums)
        {
          if (index > t)
              counter++;
        }
        result[i] = counter;
      }
      return result;
    }
  }
}
