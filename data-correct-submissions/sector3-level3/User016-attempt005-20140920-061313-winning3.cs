using System;

public class Program {
  public static int Puzzle(int[] a, int k) {
 //  int[] p=a.Distinct().ToArray();
   Array.Sort(a);
    return a[k];
  }
}