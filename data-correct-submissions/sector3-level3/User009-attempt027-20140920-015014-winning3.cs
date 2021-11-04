using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a, int k) {
	  Array.Sort(a);
    return a[k];
  }
}