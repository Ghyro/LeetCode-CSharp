using System.Collections.Generic;
using System.Linq;

namespace Medium
{
  public class UndergroundSystem
  {
    private Dictionary<int, CheckIn> checkInDct;
    private Dictionary<string, List<int>> checkOutDct;
    public UndergroundSystem()
    {
      checkInDct = new Dictionary<int, CheckIn>();
      checkOutDct = new Dictionary<string, List<int>>();
    }

    public void CheckIn(int id, string stationName, int t)
    {
      checkInDct[id] = new CheckIn { stationName = stationName, checkInTime = t };
    }

    public void CheckOut(int id, string stationName, int t)
    {
      CheckIn info = checkInDct[id];
      string key = $"{info.stationName}:{stationName}";
      int travelDuration = t - info.checkInTime;

      if (!checkOutDct.ContainsKey(key))
        checkOutDct.Add(key, new List<int>());

      checkOutDct[key].Add(travelDuration);
      checkInDct.Remove(id);
    }

    public double GetAverageTime(string startStation, string endStation)
    {
      string key = $"{startStation}:{endStation}";
      double sum = checkOutDct[key].Sum();
      int count = checkOutDct[key].Count;
      return sum / count;
    }
  }

  public class CheckIn
  {
    public string stationName { get; set; }
    public int checkInTime { get; set; }
  }
}
