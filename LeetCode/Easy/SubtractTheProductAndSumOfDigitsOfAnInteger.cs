using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Easy
{
  class SubtractTheProductAndSumOfDigitsOfAnInteger
  {
    public int SubtractProductAndSum(int n)
    {
      int products = 0;
      int sum = 0;
      string str = n.ToString();
      bool hasZero = str.Contains("0");
      for (int i = 0; i < str.Length; i++)
      {
        int digit = int.Parse(str[i].ToString());
        if (hasZero)
        {
          sum += digit;
        }
        else
        {
          products = products == 0 ? digit : products * digit;
          sum += digit;
        }
      }
      return products - sum;
    }
  }
}
