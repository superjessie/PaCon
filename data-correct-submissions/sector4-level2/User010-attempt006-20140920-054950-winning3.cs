public class Program
{

	public static int Puzzle(int m, int n)
	{
		int result = 1;
		for (int i = 1; i <= m; i++)
		{
			result *= i;
		}
		for (int i = 1; i <= n; i++)
		{
			result /= i;
		}
		for (int i = 1; i <= m - n; i++)
		{
			result /= i;
		}
		return result;
	}
}