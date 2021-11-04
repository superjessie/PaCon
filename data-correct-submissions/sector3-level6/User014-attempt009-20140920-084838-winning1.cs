using System;
using System.Linq;
public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		Array.Sort(a);
        return a.Distinct().Where(x => !b.Contains(x)).ToArray();
    }
}