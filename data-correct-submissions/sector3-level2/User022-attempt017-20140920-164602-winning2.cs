using System;

public class Program {
	
  public static int fib( int x ){
	if( x < 2 ) return 1;
	return fib(x-1) + fib(x-2);  
  }
  
  public static int Puzzle(int n) {
	if(n==0) return 0;
	
    return fib(n);
  }
}