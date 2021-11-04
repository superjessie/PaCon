using System;
using System.Linq;

public class Program {
  public static int Puzzle(int[] a) {
    return a.Max()-a.Min();
  }
}