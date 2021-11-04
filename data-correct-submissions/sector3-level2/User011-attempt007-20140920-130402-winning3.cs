public class Program
{
  public static int Puzzle(int n)
  {
	return solve(n);
  }
  private static int solve(int n)
  {
		if (n <= 3)
		{
			return n;
		}
		return solve(n - 1) + solve(n - 2);
  }
}