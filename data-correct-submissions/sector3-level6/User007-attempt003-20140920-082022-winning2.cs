using System;
using System.Linq;
using System.Collections.Generic;
public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
        HashSet<int> ahs=new HashSet<int>(a.Distinct());
		HashSet<int> bhs=new HashSet<int>(b);
		ahs.ExceptWith(bhs);
		return ahs.ToArray<int>();
    }
}