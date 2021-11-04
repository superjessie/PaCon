using System;

public class Program
{
  public static int Puzzle(int[] a)
  {

	  Array.Sort(a);
	  int sum = 0;

	  for (int i = 0; i < a.Length - 1; i++)
	  {
		  sum += a[i] - a[i + 1];
	  }
	return -sum;
  }
}