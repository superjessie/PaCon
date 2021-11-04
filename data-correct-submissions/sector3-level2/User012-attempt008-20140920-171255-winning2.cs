using System;

public class Program {
  public static int Puzzle(int n) {
	  	if(n == 0) return 0;
	  	int a = 0;
		int b = 1;
		for (int i = 0; i <= n; i++)
		{
		    int temp = a;
		    a = b;
		    b = temp + b;
		}
		return a;
  }
}