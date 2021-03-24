using System;
using System.Collections.Generic;
using System.Text;

namespace Easy
{
  class NumberOfStepsToReduceANumberToZero
  {
    public int NumberOfSteps(int num)
    {
      int steps = 0;
      while (num > 0)
      {
        if (num % 2 == 0)
        {
          num /= 2;
          steps++;
        }
        if (num % 2 != 0)
        {
          num -= 1;
          steps++;
        }
      }
      return steps;
    }
  }
}
