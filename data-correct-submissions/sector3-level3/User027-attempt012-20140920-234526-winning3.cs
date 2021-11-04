using System;
using System.Linq;
using System.Collections.Generic;

public class Program {
  public static int Puzzle(int[] a, int k) {
    List<int> b = a.ToList<int>();
    b.Sort();
    return b.ElementAt(k);
  }
}