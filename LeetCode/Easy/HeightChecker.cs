using System;

namespace Easy
{
  class HeightChecker
  {
    public int Checker(int[] heights)
    {
      int result = 0;
      int[] sorted = new int[heights.Length];
      for (int i = 0; i < heights.Length; i++)
        sorted[i] = heights[i];
      Array.Sort(sorted);
      for (int j = 0; j < heights.Length; j++)
      {
        if (heights[j] != sorted[j])
          result++;
      }
      return result;
    }
  }
}
