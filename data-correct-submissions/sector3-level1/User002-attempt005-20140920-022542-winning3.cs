using System;
using System.Linq;
public class Program {
  public static int[] Puzzle(int[] a, int t) {
    return a.Select(x => Math.Abs(x) < Math.Abs(t) ? 0 : x).ToArray();
  }
}