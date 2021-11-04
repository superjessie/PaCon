using System;

public class Program {
  public static string Puzzle(int n) {
    string output = "";
    do
    {
        output = (n % 2) + output;
        n /= 2;
    } while (n != 0);
	return output;
	
  }
}