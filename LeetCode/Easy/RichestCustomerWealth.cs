namespace Easy
{
  class RichestCustomerWealth
  {
    public int MaximumWealth(int[][] accounts)
    {
      int max = 0;
      int[] mass = new int[accounts.Length];
      for (int i = 0; i < accounts.Length; i++)
      {
        int sum = 0;
        for (int j = 0; j < accounts[i].Length; j++)
            sum += accounts[i][j];
        mass[i] = sum;
      }
      for (int i = 0; i < mass.Length; i++)
      {
        if (mass[i] > max)
            max = mass[i];
      }
      return max;
    }
  }
}
