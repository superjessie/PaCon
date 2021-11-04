using System;

public class Program {
  public static int Puzzle(int n) {
	  if(n==0) return 0;
	  if(n==1) return 1;
	  var last = 1;
	  var now = 1;
	  for(int i=2;i<n;i++){
		  var tmp = last;
		  last = now;
		  now = last + tmp;
	  }
	  return last + now;
  }
}