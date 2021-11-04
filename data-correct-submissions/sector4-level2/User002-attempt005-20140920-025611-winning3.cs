using System;

public static class Program {
    public static int Puzzle(int m, int n) {
        return n==0?1:m==n?1:m<n?0:(Puzzle(m-1,n-1)+Puzzle(m-1,n));
    }
}