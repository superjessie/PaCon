using System;

public class Program
{
  public static int Puzzle(int[] a)
  {
	  int max = a[0];
	  int min = a[0];
	  for (int i = 0; i < a.Length; ++i)
	  {
		  max = Math.Max(max, a[i]);
		  min = Math.Min(min, a[i]);
	  }

	return (max - min);
  }
}