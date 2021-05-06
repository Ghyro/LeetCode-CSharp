namespace Easy
{
  class NumberOfStudentsDoingHomeworkAtAGivenTime
  {
    public int BusyStudent(int[] startTime, int[] endTime, int queryTime)
    {
      int output = 0;
      int i = 0;
      while (i < startTime.Length)
      {
        if (startTime[i] <= queryTime && endTime[i] >= queryTime)        
          output++;   
        i++;
      }
      return output;
    }
  }
}
