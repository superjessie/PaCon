using System;

public static class Program {
    public static int Puzzle(int m, int n) {
		int a=1,b=1;
		if (n==0 || m==n) return 1;
		if (n>m/2) n=m-n;
		while (n>0){
			a = a*(m-n+1);
			b = b*n;
			n -=1;
		}
		return a/b;
    }
}