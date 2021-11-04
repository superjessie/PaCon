using System;

public class Program {
  public static string Puzzle(int n) {
	  string p = "";
	     while(n>=2){
		 p =  (n%2).ToString() + p;
		 n = n/2;
	 }
	 p =n.ToString() + p;
    return p;
  }
}