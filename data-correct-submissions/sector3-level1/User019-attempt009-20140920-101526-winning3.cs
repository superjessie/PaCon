using System;

public class Program {
  public static int[] Puzzle(int[] a, int t) {
	  int [] b = new int[a.Length];
	  
	
 for(int i=0;i<b.Length;i++)
 {
	 b[i] = (Math.Abs(a[i])>=t)?a[i]:0;
 }
    return b;
  }
}