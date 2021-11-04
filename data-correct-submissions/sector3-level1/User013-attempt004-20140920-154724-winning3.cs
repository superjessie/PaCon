using System;

public class Program
{
  public static int[] Puzzle(int[] a, int t)
  {
	int[] ret = new int[a.Length];
	for (int i = 0;i < a.Length;i++)
	{
		if (Math.Abs(a[i] / t) >= 1)
		{
			ret[i] = a[i];
		}
		else
		{
			ret[i] = 0;
		}
	}
	return ret;
  }
}