using System;

public class Program {
  public static int Puzzle(int n) {
	  if(n <= 2) return n;
	  else return(Puzzle(n-1) + Puzzle(n-2));
  }
}