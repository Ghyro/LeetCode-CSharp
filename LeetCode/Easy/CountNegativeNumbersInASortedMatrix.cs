using System.Collections.Generic;

namespace Easy
{
  class CountNegativeNumbersInASortedMatrix
  {
    public int CountNegatives(int[][] grid)
    {
      int result = 0;
      foreach (var row in grid)
      {
        foreach (var item in row)
        {
          if (item < 0)
          {
            result++;
          }
        }
      }
      return result;
    }
  }
}
