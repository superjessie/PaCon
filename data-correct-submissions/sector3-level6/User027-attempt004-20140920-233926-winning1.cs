using System;
using System.Linq;
using System.Collections.Generic;

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
        List<int> c = a.Distinct().ToList<int>();
        for (int i = 0; i < b.Length;i++ )
        {
            while (c.Contains(b[i]))
                c.Remove(b[i]);
        }
        c.Sort();
        int[] d = c.ToArray();
		return d;
    }
}