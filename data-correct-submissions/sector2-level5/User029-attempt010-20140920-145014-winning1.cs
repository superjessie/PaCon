using System;

public class Program {
  public static int Puzzle(int[] a) {
	  int max=0;
	  foreach(int i in a){
		foreach(int j in a){
		  max=i-j>max?i-j:max;
	  }
	  }
    return max;
  }
}