using System;

public class Program {
  public static int[] Puzzle(int[] a, int t) {
	  int [] b = new int[a.Length];
	  
	/* if(t%10==0)
	 {
	  for(int i=1;i<b.Length;i++)
	  {
	  	 b[i]=(a[i]%t==0)?a[i]:0;
	  } 
	 }
	 else 
 {
	 for(int i=1;i<b.Length;i++)
	  {
	  	 b[i]=a[i];
	  } 
 } */
 for(int i=0;i<b.Length;i++)
 {
	 b[i] = (Math.Abs(a[i])>=t)?a[i]:0;
 }
    return b;
  }
}