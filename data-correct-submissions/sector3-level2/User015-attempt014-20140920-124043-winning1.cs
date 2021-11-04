using System;
using System.Linq;
public class Program {
  public static int Puzzle(int n) {
	if(n==0) return 0;
	Func<int, int> fibonacci = null;
    fibonacci = (x) => x > 1 ? fibonacci(x - 1) + fibonacci(x - 2) : x;
    return fibonacci(n + 1);
  }
}