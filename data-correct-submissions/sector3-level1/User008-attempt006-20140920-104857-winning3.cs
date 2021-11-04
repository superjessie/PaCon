using System;

public class Program
{
  public static int[] Puzzle(int[] a, int t)
  {
	  for (int i = 0; i < a.Length; ++i)
	  {
		  if (Math.Abs(a[i] / t) <= 0)
		  {
			  a[i] = 0;
		  }
	  }
	return a;
  }
}