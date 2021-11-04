using System;

public class Program {
  public static int Puzzle(int n) {
    int a = 0;
	int b = 1;
	
	for (int i = 0; i < n+1; i++)
	{
	    int temp = a;
	    a = b;
	    b = temp + b;
	}
	if (n!=0)
		return a;
		else
		return 0;

  }
}