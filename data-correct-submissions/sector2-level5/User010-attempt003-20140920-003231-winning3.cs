using System;

public class Program
{
  public static int Puzzle(int[] a)
  {
	int max = int.MinValue, min = int.MaxValue;
	for (int i = 0; i < a.Length; i++)
	{
		max = Math.Max(max, a[i]);
		min = Math.Min(min, a[i]);
	}
	return max - min;
  }
}