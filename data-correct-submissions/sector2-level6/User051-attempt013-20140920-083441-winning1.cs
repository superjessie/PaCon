using System;

public class Program {
  public static string Puzzle(int n) {
	  string p = "";
	     while(n>=2){
		 int a = n%2;
		 p =  a.ToString() + p;
		 n = (int)n/2;
	 }
	 p =n.ToString() + p;
    return p;
  }
}