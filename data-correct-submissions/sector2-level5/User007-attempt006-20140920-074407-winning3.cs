using System;

public class Program {
  public static int Puzzle(int[] a) {
    Array.Sort(a);
	return a[a.Length-1]-a[0];
  }
}