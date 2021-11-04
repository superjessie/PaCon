using System;

public static class Program {
	public static int f(int n) {
		return n == 0 ? 1 : f(n-1)*n;
	} 
    public static int Puzzle(int m, int n) {
		return f(m)/(f(n)*f(m-n));
    }
}