public class Program
{
  public static int Puzzle(int n)
  {
	int[] feb = new int[n + 1];
if (n >= 4)
{
		 feb[0] = 0;
		 feb[1] = 1;
		 feb[2] = 2;
		 feb[3] = 3;
		 for (int i = 4; i <= n; i++)
		 {
			 feb[i] = feb[i - 1] + feb[i - 2];
		 }
		return feb[n];
}
else
{
	return n;
}
  }
}