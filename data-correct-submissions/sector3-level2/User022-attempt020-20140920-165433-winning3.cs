using System;

public class Program {
  
  public static int Puzzle(int n) {
	if(n==0) return 0;
	if( n <= 2 ) return n;
	return Puzzle(n-1) + Puzzle(n-2);
  }
}