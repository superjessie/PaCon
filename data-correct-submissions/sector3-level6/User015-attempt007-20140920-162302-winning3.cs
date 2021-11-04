using System;
using System.Linq;
public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
        int[] v = a.Except(b).ToArray();
        Array.Sort(v);
		return v;
            
    }
}