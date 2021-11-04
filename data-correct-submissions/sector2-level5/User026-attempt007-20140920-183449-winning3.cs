using System;

public class Program
{
  public static int Puzzle(int[] a)
  {
	int soma = 0;

		Array.Sort(a);
	return a[a.Length - 1] - a[0];

  }
}