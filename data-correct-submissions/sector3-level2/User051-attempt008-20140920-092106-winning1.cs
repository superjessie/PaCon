using System;

public class Program {
  public static int Puzzle(int n) {
	  if(n>=0&&n<3) return n;
	  int a=1,b=2,c=0;
            for (int i = 1; i < n-1; i++)
            {
               c = a + b;
                a = b;
                b = c;
            }
    return c;
  }
}