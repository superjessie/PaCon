using System;

public class Program {
  public static int[] Puzzle(int[] a, int t) {
	  int[] temp = new int[a.Length];
	  
	  for(int i = 0; i < a.Length; i++)
	  {
		  temp[i]=a[i];
	  	if(a[i]/t==0)
		  temp[i]=0;
	  }
    return temp;
  }
}