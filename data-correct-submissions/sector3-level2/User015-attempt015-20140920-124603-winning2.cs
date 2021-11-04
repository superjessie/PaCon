using System;
public class Program {
  public static int Puzzle(int n) {
	if (n <= 1)
        return n;
    int fibonacciSum = 1, fibonacciLast = 1;
    n++;
    for (int i = 2; i < n; i++)
    {
        int temp = fibonacciSum;
        fibonacciSum += fibonacciLast;
        fibonacciLast = temp;
    }
    return fibonacciSum;
  }
}