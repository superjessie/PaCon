using System;

public class Program {
  public static int Puzzle(int[] a) {
	  
		  int s, l;
		  s=l=a[0];
		  for(int i=1;i<a.Length;i++){
			  if(a[i]<s)
			  s=a[i];
			  if(a[i]>l)
			  l=a[i];
			  
		  }
		  
			return l-s;
	  
    
  }
}