namespace Medium
{
  public class CustomStack
  {
    private int[] array;
    private int count;
    private int n;
    public CustomStack(int maxSize)
    {
      array = new int[maxSize];
      n = maxSize;
    }

    public void Push(int x)
    {
      if (count + 1 > n)
        return;
      if (array.Length == count)
        Resize(array.Length + 1);
      array[count] = x;
      count++;
    }

    public int Pop()
    {
      if (count == 0)
        return -1;
      int item = array[--count];
      array[count] = 0;
      if (count >= 0)
        Resize(count);
      return item;
    }

    public void Increment(int k, int val)
    {
      if (array.Length != 0)
      {
        int diff = k > array.Length ? array.Length : k;
        for (int i = 0; i < diff; i++)
          array[i] += val;
      }
    }

    private void Resize(int size)
    {
      int[] temp = new int[size];
      for (int i = 0; i < count; i++)
        temp[i] = array[i];
      array = temp;
    }
  }
}
