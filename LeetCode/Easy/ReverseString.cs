namespace Easy
{
  class ReverseString
  {
    public void Reverse(char[] s)
    {
      char temp;
      for (int i = 0; i < s.Length / 2; i++)
      {
        temp = s[i];
        s[i] = s[s.Length - 1 - i];
        s[s.Length - 1 - i] = temp;
      }
    }
  }
}
