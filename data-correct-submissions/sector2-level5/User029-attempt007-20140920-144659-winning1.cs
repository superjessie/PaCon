using System;

public class Program {
  public static int Puzzle(int[] a) {
	  int max=a[0],min=a[0];
	  foreach(int i in a){
		  max=i>max?i:max;
		  min=i<min?i:min;
	  }
    return max-min;
  }
}