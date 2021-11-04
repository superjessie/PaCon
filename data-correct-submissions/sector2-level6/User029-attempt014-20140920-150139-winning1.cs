using System;

public class Program {
  public static string Puzzle(int n) {
	  string binary="";
	  do
	  {
		  binary = ((n % 2 == 0)?"0":"1") + binary;
		  n = n / 2;
	  }
	  while(n!=0);
    return binary;
  }
}