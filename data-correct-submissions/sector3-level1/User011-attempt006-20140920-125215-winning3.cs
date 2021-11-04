using System;

public class Program
{
  public static int[] Puzzle(int[] a, int t)
  {
	  int @in = 0;
		foreach (int item in a)
		{
			if (Math.Abs(item) >= t)
			{
				a[@in] = item;
			}
			else
			{
				a[@in] = 0;
			}
			@in++;
		}
		return a;
  }
}