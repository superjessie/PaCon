using System;
public class Program {
  public static string Puzzle(int n) {
	if(n==0)return "0";
	else if(n==1)return "1";
	string suffix = n%2==0?"0":"1";
	return Puzzle(n/2) + suffix;
  }
}