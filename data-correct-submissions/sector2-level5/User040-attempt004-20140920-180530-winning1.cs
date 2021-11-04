using System;

public class Program {
  public static int Puzzle(int[] a) {
	  int min = a[0];
	  int max = a[0];
	  foreach(int i in a)
	  	if(i > max) max = i;
		else if(i < min) min = i;
    return max - min;
  }
}