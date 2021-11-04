using System;

public class Program {
  public static int Puzzle(int n) {
	int res = Math.Min(n,3);
	int res2 = res-1;
	for (int i=4;i<=n;i++)
	{
		res = res+res2;
		res2 = res-res2;
	}
	return res;
  }
}