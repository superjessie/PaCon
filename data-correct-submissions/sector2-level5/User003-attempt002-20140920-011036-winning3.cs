using System;

public class Program
{
  public static int Puzzle(int[] a)
  {
	int max = int.MinValue;
	int min = int.MaxValue;
	foreach (int x in a)
	{
		max = (int)Math.Max(x,max);
		min = (int)Math.Min(x,min);
	}
	return max - min;
  }
}