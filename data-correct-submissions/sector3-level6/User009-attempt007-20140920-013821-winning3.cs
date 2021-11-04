using System;
using System.Collections.Generic;
using System.Linq;

public static class Program {
    public static int[] Puzzle(int[] a, int[] b) {
		var result = new List<int>();
		
		foreach(var i in a)
		{
			if (!b.Any(x => x == i) && !result.Any(x => x==i))
			  result.Add(i);
		}
		
        return result.ToArray();
    }
}