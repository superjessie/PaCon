using System;
using System.Linq;
public class Program {
  public static int Puzzle(int[] a) {
	 /* 
    int h = int.MinValue, l = int.MaxValue;
	for(int i=0;i<a.Length;i++){
		if(a[i] > h) h = a[i];
		if(a[i] < l) l = a[i];
	} 
	
	return h - l;
	*/
	return a.Max()-a.Min();
  }
}