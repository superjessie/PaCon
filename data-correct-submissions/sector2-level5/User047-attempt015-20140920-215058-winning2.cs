using System;

public class Program
{
  public static int Puzzle(int[] a)
  {
	  int high = int.MinValue;
	  int low = int.MaxValue;
	  foreach (int check in a)
	  {
		  high = Math.Max(high, check);
		  low = Math.Min(low, check);
	  }
	  return high - low;
  }
}