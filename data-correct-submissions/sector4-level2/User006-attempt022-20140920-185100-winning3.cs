public class Program
{
	public static int Puzzle(int m, int n)
	{
		int ans = 1;
		for (int i = 1; i <= n; i++)
		{
				ans = ans * (m - i + 1) / i;
		}
		return ans;
	}
}