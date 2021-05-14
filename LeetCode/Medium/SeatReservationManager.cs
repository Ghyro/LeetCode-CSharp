using System.Collections.Generic;
using System.Linq;

namespace Medium
{
  public class SeatManager
  {
    SortedDictionary<int, bool> seats;
    public SeatManager(int n)
    {
      seats = new SortedDictionary<int, bool>();
      for (int i = 1; i <= n; i++)
        seats.Add(i, true);
    }

    public int Reserve()
    {
      var key = seats.First().Key;
      seats.Remove(key);
      return key;
    }

    public void Unreserve(int seatNumber)
    {
      seats.Add(seatNumber, true);
    }
  }
}
