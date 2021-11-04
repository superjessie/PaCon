using System;
using System.Linq;
public class Program {
  public static int Puzzle(int n) {
	  if (n == 0) return 0;
       return Fib(n);
}

public static int Fib(int n)
{
    if (n < 2) return 1;
    return Fib(n - 2) + Fib(n - 1);
  }
}