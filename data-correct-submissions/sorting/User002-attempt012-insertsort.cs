using System;
using System.Collections.Generic;

public class Program {
	public static int[] Sort(int[] a) {
      Sort(a, 0, a.Length - 1);
      return a;
    }
 
    public static void Sort(int[] a, Int32 first, Int32 last) {
      for (var i = first + 1; i <= last; i++) {
        var entry = a[i];
        var j = i;
 
        while (j > first && a[j - 1] > entry)
          a[j] = a[--j];
 
        a[j] = entry;
      }
    }
}
