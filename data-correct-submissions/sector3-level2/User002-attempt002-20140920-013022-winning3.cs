using System;

public class Program {
  public static int Puzzle(int n) {
    return n < 3 ? n : Puzzle(n-1) + Puzzle(n-2);
  }
}