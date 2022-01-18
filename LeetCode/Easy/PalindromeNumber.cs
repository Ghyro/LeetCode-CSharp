namespace Easy
{
    // Issue: 9
    class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            var val = x.ToString();
            for (int i = 0; i < val.Length / 2; i++)
            {
                if (val[i] != val[val.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
