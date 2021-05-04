namespace Easy
{
  class Maximum69Number
  {
    public int Maximum69NumberMethod(int num)
    {
      int attempts = 1;
      string str = num.ToString();
      char[] arr = new char[str.Length];
      for (int i = 0; i < str.Length; i++)
      {
        if (str[i] == '6' && attempts > 0)
        {
          arr[i] = '9';
          attempts--;
        }
        else
        {
          arr[i] = str[i];
        }
      }
      return int.Parse(new string(arr));
    }
  }
}
