public class Program
{
	public static int Puzzle(int m, int n)
	{
		int p = 1;
		  for (int i = n + 1;i <= m;i++)
		  {
			  p *= i;
		  }
		for (int i = 2;i <= m - n;i++)
		{
			  p /= i;
		}
		 return p;
	}
}