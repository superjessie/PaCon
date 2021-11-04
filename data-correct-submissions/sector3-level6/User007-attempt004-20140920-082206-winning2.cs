using System;
using System.Linq;
using System.Collections.Generic;
public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
        HashSet<int> ahs=new HashSet<int>(a.Distinct());
		ahs.ExceptWith(new HashSet<int>(b));
		return ahs.ToArray<int>();
    }
}