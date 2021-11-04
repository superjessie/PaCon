using System;
using System.Linq;
public static class Program {
    public static int Puzzle(int m, int n) {
		if(m==n || n==0) return 1;
        int factorialM = Enumerable.Range(1, m).Aggregate((f, s) => f * s);
        int factorialN = Enumerable.Range(1, n).Aggregate((f, s) => f * s);
        int factorialMN = Enumerable.Range(1, m-n).Aggregate((f, s) => f * s);
        return factorialM/(factorialMN*factorialN);
    }
}