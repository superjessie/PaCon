using System;

public class Program {
  public static int Puzzle(int n) {
	  int x = 0, y = 1, z=0, i;


for (i = 1; i <= n; i++)
{
z = x + y;
x = y;
y = z;
}
    return z;
  }
}