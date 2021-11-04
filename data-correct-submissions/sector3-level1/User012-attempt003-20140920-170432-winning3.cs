using System;

public class Program {
  public static int[] Puzzle(int[] a, int t) {
    for(int i=0;i<a.Length;++i) {
		a[i] = Math.Abs(a[i]) >= t ? a[i] : 0;
	}
	return a;
  }
}