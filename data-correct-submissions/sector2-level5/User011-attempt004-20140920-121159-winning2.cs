using System;

public class Program
{
  public static int Puzzle(int[] a)
  {
	int maxi = a[0], mini = a[0];
		foreach (int item in a)
		{
			maxi = Math.Max(maxi,item);
			mini = Math.Min(mini,item);
		}
		return maxi - mini;
  }
}