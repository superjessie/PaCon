using System;

public static class Program {
    public static int Puzzle(int m, int n) {
		Func<int, int> factorial = null; 
    	factorial = x => x <= 1 ? 1 : x * factorial(x-1);
		return factorial(m)/(factorial(n)*factorial(m-n));
    }
}