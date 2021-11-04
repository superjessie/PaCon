using System;

public static class Program {
    public static int Puzzle(int m, int n) {
		if(n==0 || m==n)return 1;
		return Puzzle(m-1, n-1) + Puzzle(m-1,n);
    }
}